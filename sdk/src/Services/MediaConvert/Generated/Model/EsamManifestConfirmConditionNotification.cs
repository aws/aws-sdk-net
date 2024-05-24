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

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// ESAM ManifestConfirmConditionNotification defined by OC-SP-ESAM-API-I03-131025.
    /// </summary>
    public partial class EsamManifestConfirmConditionNotification
    {
        private string _mccXml;

        /// <summary>
        /// Gets and sets the property MccXml. Provide your ESAM ManifestConfirmConditionNotification
        /// XML document inside your JSON job settings. Form the XML document as per OC-SP-ESAM-API-I03-131025.
        /// The transcoder will use the Manifest Conditioning instructions in the message that
        /// you supply.
        /// </summary>
        public string MccXml
        {
            get { return this._mccXml; }
            set { this._mccXml = value; }
        }

        // Check to see if MccXml property is set
        internal bool IsSetMccXml()
        {
            return this._mccXml != null;
        }

    }
}