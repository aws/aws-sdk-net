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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSecurityProfiles operation.
    /// Associate security profiles with an Entity in an Amazon Connect instance.
    /// </summary>
    public partial class AssociateSecurityProfilesRequest : AmazonConnectRequest
    {
        private string _entityArn;
        private EntityType _entityType;
        private string _instanceId;
        private List<SecurityProfileItem> _securityProfiles = AWSConfigs.InitializeCollections ? new List<SecurityProfileItem>() : null;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        ///  Arn of a Q in Connect AI Agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        ///  Only supported type is AI_AGENT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///  The identifier of the Amazon Connect instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfiles. 
        /// <para>
        ///  List of Security Profile Object. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<SecurityProfileItem> SecurityProfiles
        {
            get { return this._securityProfiles; }
            set { this._securityProfiles = value; }
        }

        // Check to see if SecurityProfiles property is set
        internal bool IsSetSecurityProfiles()
        {
            return this._securityProfiles != null && (this._securityProfiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}