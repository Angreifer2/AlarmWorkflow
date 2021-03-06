﻿// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using AlarmWorkflow.Shared.Properties;

namespace AlarmWorkflow.Shared.ObjectExpressions
{
    /// <summary>
    /// Represents an exception that is thrown when an expression was in an invalid format, or pointed to a member in an unsupported way.
    /// </summary>
    public class ExpressionNotSupportedException : ExpressionException
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionNotSupportedException"/> class.
        /// </summary>
        public ExpressionNotSupportedException()
            : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionNotSupportedException"/> class.
        /// </summary>
        /// <param name="expression">The unsupported expression.</param>
        public ExpressionNotSupportedException(string expression)
            : base(string.Format(Resources.ExpressionNotSupportedExceptionMessage, expression))
        {
        }

        #endregion
    }
}