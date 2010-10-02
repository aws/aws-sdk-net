/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information returned by the service request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class CreateDBSnapshotResponse
    {
        private CreateDBSnapshotResult createDBSnapshotResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the CreateDBSnapshotResult property.
        /// Information on the DB Snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateDBSnapshotResult")]
        public CreateDBSnapshotResult CreateDBSnapshotResult
        {
            get { return this.createDBSnapshotResultField; }
            set { this.createDBSnapshotResultField = value; }
        }

        /// <summary>
        /// Checks if CreateDBSnapshotResult property is set
        /// </summary>
        /// <returns>true if CreateDBSnapshotResult property is set</returns>
        public bool IsSetCreateDBSnapshotResult()
        {
            return this.createDBSnapshotResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Information about the request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
