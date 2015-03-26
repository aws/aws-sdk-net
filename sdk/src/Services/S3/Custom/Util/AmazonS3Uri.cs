/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Uri wrapper that can parse out information (bucket, key, region, style) from an
    /// S3 URI.
    /// </summary>
    public class AmazonS3Uri : Amazon.Runtime.Internal.Util.S3Uri
    {
        /// <summary>
        /// Constructs a parser for the S3 URI specified as a string.
        /// </summary>
        /// <param name="uri">The S3 URI to be parsed.</param>
        public AmazonS3Uri(string uri)
            : base(new Uri(uri))
        {
        }

        /// <summary>
        /// Constructs a parser for the S3 URI specified as a Uri instance.
        /// </summary>
        /// <param name="uri">The S3 URI to be parsed.</param>
        public AmazonS3Uri(Uri uri)
            : base(uri)
        {

        }
    }
}
