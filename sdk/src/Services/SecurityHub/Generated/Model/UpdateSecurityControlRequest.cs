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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityControl operation.
    /// Updates the properties of a security control.
    /// </summary>
    public partial class UpdateSecurityControlRequest : AmazonSecurityHubRequest
    {
        private string _lastUpdateReason;
        private Dictionary<string, ParameterConfiguration> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterConfiguration>() : null;
        private string _securityControlId;

        /// <summary>
        /// Gets and sets the property LastUpdateReason. 
        /// <para>
        ///  The most recent reason for updating the properties of the security control. This
        /// field accepts alphanumeric characters in addition to white spaces, dashes, and underscores.
        /// 
        /// </para>
        /// </summary>
        public string LastUpdateReason
        {
            get { return this._lastUpdateReason; }
            set { this._lastUpdateReason = value; }
        }

        // Check to see if LastUpdateReason property is set
        internal bool IsSetLastUpdateReason()
        {
            return this._lastUpdateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  An object that specifies which security control parameters to update. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, ParameterConfiguration> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The Amazon Resource Name (ARN) or ID of the control to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

    }
}