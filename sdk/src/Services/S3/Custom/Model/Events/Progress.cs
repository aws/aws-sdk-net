// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The Progress event details.
    /// </summary>
    public class Progress
    {
        /// <summary>
        /// Current number of object bytes scanned.
        /// </summary>
        public long BytesScanned { get; set; }
        /// <summary>
        /// Current number of uncompressed object bytes processed.
        /// </summary>
        public long BytesProcessed { get; set; }
        /// <summary>
        /// Total number of bytes of records payload data returned.
        /// </summary>
        public long BytesReturned { get; set; }

        /// <summary>
        /// Constructs a instance of Progress.
        /// </summary>
        public Progress()
        {
        }

        internal static Progress Unmarshall(byte[] payload)
        {
            var xmlString = Encoding.UTF8.GetString(payload,0, payload.Length);
            var topNode = XElement.Parse(xmlString);
            if (topNode.Name != "Progress")
            {
                throw new InvalidOperationException("Top element name expected to be \"Progress\"");
            }

            var bytesScanned = long.Parse(topNode.Descendants(nameof(BytesScanned)).First().Value, CultureInfo.InvariantCulture);
            var bytesProcessed = long.Parse(topNode.Descendants(nameof(BytesProcessed)).First().Value, CultureInfo.InvariantCulture);
            var bytesReturned = long.Parse(topNode.Descendants(nameof(BytesReturned)).First().Value, CultureInfo.InvariantCulture);
            return new Progress()
            {
                BytesScanned = bytesScanned,
                BytesProcessed = bytesProcessed,
                BytesReturned = bytesReturned
            };
        }
    }
}