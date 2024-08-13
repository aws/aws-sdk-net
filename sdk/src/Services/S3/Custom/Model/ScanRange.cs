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

using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the byte range of the object to get the records from. A record is processed when its first byte is contained by the range.
    /// </summary>
    public class ScanRange
    {
        private long? start;
        private long? end;

        /// <summary>
        /// Specifies the start of the byte range. This parameter is optional. Valid values: non-negative integers. The default value is 0.
        /// </summary>
        public long? Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        internal bool IsSetStart()
        {
            return this.start.HasValue;
        }

        /// <summary>
        /// Specifies the end of the byte range. This parameter is optional. Valid values: non-negative integers. The default value is one less than the size of the object being queried.
        /// </summary>
        public long? End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        internal bool IsSetEnd()
        {
            return this.end.HasValue;
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetStart())
                    xmlWriter.WriteElementString("Start", S3Transforms.ToXmlStringValue(Start.Value));
                if (IsSetEnd())
                    xmlWriter.WriteElementString("End", S3Transforms.ToXmlStringValue(End.Value));
            }
            xmlWriter.WriteEndElement();

        }
    }
}
