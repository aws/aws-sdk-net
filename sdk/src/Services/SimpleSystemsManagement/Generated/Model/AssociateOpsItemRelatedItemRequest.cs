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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateOpsItemRelatedItem operation.
    /// Associates a related item to a Systems Manager OpsCenter OpsItem. For example, you
    /// can associate an Incident Manager incident or analysis with an OpsItem. Incident Manager
    /// and OpsCenter are tools in Amazon Web Services Systems Manager.
    /// </summary>
    public partial class AssociateOpsItemRelatedItemRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _associationType;
        private string _opsItemId;
        private string _resourceType;
        private string _resourceUri;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association that you want to create between an OpsItem and a resource.
        /// OpsCenter supports <c>IsParentOf</c> and <c>RelatesTo</c> association types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem to which you want to associate a resource as a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpsItemId
        {
            get { return this._opsItemId; }
            set { this._opsItemId = value; }
        }

        // Check to see if OpsItemId property is set
        internal bool IsSetOpsItemId()
        {
            return this._opsItemId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that you want to associate with an OpsItem. OpsCenter supports
        /// the following types:
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS::SSMIncidents::IncidentRecord</c>: an Incident Manager incident. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS::SSM::Document</c>: a Systems Manager (SSM) document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceUri. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services resource that you want to
        /// associate with the OpsItem.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceUri
        {
            get { return this._resourceUri; }
            set { this._resourceUri = value; }
        }

        // Check to see if ResourceUri property is set
        internal bool IsSetResourceUri()
        {
            return this._resourceUri != null;
        }

    }
}