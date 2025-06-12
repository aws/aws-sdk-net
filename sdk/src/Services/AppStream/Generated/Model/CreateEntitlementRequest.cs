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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEntitlement operation.
    /// Creates a new entitlement. Entitlements control access to specific applications within
    /// a stack, based on user attributes. Entitlements apply to SAML 2.0 federated user identities.
    /// Amazon AppStream 2.0 user pool and streaming URL users are entitled to all applications
    /// in a stack. Entitlements don't apply to the desktop stream view application, or to
    /// applications managed by a dynamic app provider using the Dynamic Application Framework.
    /// </summary>
    public partial class CreateEntitlementRequest : AmazonAppStreamRequest
    {
        private AppVisibility _appVisibility;
        private List<EntitlementAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<EntitlementAttribute>() : null;
        private string _description;
        private string _name;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property AppVisibility. 
        /// <para>
        /// Specifies whether all or selected apps are entitled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppVisibility AppVisibility
        {
            get { return this._appVisibility; }
            set { this._appVisibility = value; }
        }

        // Check to see if AppVisibility property is set
        internal bool IsSetAppVisibility()
        {
            return this._appVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the entitlement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<EntitlementAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack with which the entitlement is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}