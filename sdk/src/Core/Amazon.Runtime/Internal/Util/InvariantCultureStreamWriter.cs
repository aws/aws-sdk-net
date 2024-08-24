/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Globalization;
using System.IO;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A <see cref="StreamWriter"/> that uses the invariant culture for formatting.
    /// </summary>
    public class InvariantCultureStreamWriter : StreamWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvariantCultureStreamWriter"/> class with the specified stream.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        public InvariantCultureStreamWriter(Stream stream)
            : base(stream)
        {
        }

        /// <inheritdoc/>
        public override IFormatProvider FormatProvider
        {
            get
            {
                return CultureInfo.InvariantCulture;
            }
        }
    }
}
