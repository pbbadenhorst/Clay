#region License

// Copyright (c) K2 Workflow (SourceCode Technology Holdings Inc.). All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

#endregion

using System;
using System.Data;

namespace SourceCode.Clay.Data.SqlParser
{
    public struct SqlParamInfo : IEquatable<SqlParamInfo>
    {
        #region Constants

        public static SqlParamInfo Empty { get; }

        #endregion

        #region Properties

        public bool IsNullable { get; }

        public bool HasDefault { get; }

        public bool IsReadOnly { get; }

        public ParameterDirection Direction { get; }

        #endregion

        #region Constructors

        public SqlParamInfo(bool isNullable, bool hasDefault, bool isReadOnly, ParameterDirection direction)
        {
            if (!Enum.IsDefined(typeof(ParameterDirection), direction)) throw new ArgumentOutOfRangeException(nameof(direction));

            IsNullable = isNullable;
            HasDefault = hasDefault;
            IsReadOnly = isReadOnly;
            Direction = direction;
        }

        #endregion

        #region IEquatable

        public bool Equals(SqlParamInfo other)
            => IsNullable == other.IsNullable
            && HasDefault == other.HasDefault
            && IsReadOnly == other.IsReadOnly
            && Direction == other.Direction;

        public override bool Equals(object obj)
            => obj is SqlParamInfo prm
            && Equals(prm);

        public override int GetHashCode()
        {
            var hc = 17L;

            unchecked
            {
                hc = hc * 23 + (IsNullable ? 9 : 4);
                hc = hc * 23 + ((int)Direction);
                hc = hc * 23 + (HasDefault ? 2 : 21);
                hc = hc * 23 + (IsReadOnly ? 17 : 8);
            }

            return ((int)(hc >> 32)) ^ (int)hc;
        }

        #endregion

        #region Override

        public override string ToString()
            => $"{Direction}"
            + (IsNullable ? ", Null" : string.Empty)
            + (HasDefault ? ", Default" : string.Empty)
            + (IsReadOnly ? ", ReadOnly" : string.Empty);

        #endregion
    }
}