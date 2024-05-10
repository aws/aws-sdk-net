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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateResource operation.
    /// Disassociates a resource from application. Both the resource and the application
    /// can be specified either by ID or name. 
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    ///  You must have the following permissions to remove a resource that's been associated
    /// with an application using the <c>APPLY_APPLICATION_TAG</c> option for <a href="https://docs.aws.amazon.com/servicecatalog/latest/dg/API_app-registry_AssociateResource.html">AssociateResource</a>.
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>tag:GetResources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>tag:UntagResources</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  You must also have the following permissions if you don't use the <c>AWSServiceCatalogAppRegistryFullAccess</c>
    /// policy. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/arguide/full.html">AWSServiceCatalogAppRegistryFullAccess</a>
    /// in the AppRegistry Administrator Guide. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>resource-groups:DisassociateResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudformation:UpdateStack</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudformation:DescribeStacks</c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  In addition, you must have the tagging permission defined by the Amazon Web Services
    /// service that creates the resource. For more information, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_UntTagResources.html">UntagResources</a>
    /// in the <i>Resource Groups Tagging API Reference</i>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisassociateResourceRequest : AmazonAppRegistryRequest
    {
        private string _application;
        private string _resource;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The name or ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name or ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that is being disassociated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}