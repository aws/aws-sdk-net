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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes the location where the restore job's output is stored.
    /// </summary>
    public class OutputLocation
    {
        /// <summary>
        /// Describes an S3 location that will receive the results of the restore request.
        /// </summary>
        public S3Location S3 { get; set; }

        internal bool IsSetS3()
        {
            return this.S3 != null;
        }

        internal void Marshall(string propertyName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(propertyName);
            {
                S3.Marshall("S3", xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
    }
}
