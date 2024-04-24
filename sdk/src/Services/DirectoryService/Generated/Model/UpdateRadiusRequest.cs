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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRadius operation.
    /// Updates the Remote Authentication Dial In User Service (RADIUS) server information
    /// for an AD Connector or Microsoft AD directory.
    /// </summary>
    public partial class UpdateRadiusRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private RadiusSettings _radiusSettings;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to update the RADIUS server information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusSettings. 
        /// <para>
        /// A <a>RadiusSettings</a> object that contains information about the RADIUS server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RadiusSettings RadiusSettings
        {
            get { return this._radiusSettings; }
            set { this._radiusSettings = value; }
        }

        // Check to see if RadiusSettings property is set
        internal bool IsSetRadiusSettings()
        {
            return this._radiusSettings != null;
        }

    }
}