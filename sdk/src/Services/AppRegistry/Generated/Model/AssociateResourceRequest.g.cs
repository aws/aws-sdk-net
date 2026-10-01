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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AssociateResource operation. Associates a resource
    /// with an application. The resource can be specified by its ARN or name. The application
    /// can be specified by ARN, ID, or name. <para> <b>Minimum permissions</b> </para> <para>
    /// You must have the following permissions to associate a resource using the <c>OPTIONS</c>
    /// parameter set to <c>APPLY_APPLICATION_TAG</c>. </para> <ul> <li> <para> <c>tag:GetResources</c>
    /// </para> </li> <li> <para> <c>tag:TagResources</c> </para> </li> </ul> <para> You must
    /// also have these additional permissions if you don't use the <c>AWSServiceCatalogAppRegistryFullAccess</c>
    /// policy. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/arguide/full.html">AWSServiceCatalogAppRegistryFullAccess</a>
    /// in the AppRegistry Administrator Guide. </para> <ul> <li> <para> <c>resource-groups:AssociateResource</c>
    /// </para> </li> <li> <para> <c>cloudformation:UpdateStack</c> </para> </li> <li> <para>
    /// <c>cloudformation:DescribeStacks</c> </para> </li> </ul> <note> <para> In addition,
    /// you must have the tagging permission defined by the Amazon Web Services service that
    /// creates the resource. For more information, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_TagResources.html">TagResources</a>
    /// in the <i>Resource Groups Tagging API Reference</i>. </para> </note>
    /// </summary>
    public partial class AssociateResourceRequest : AmazonAppRegistryRequest
    {
        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        ///  The name, ID, or ARN of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        ///  Determines whether an application tag is applied or skipped. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name or ID of the resource of which the application will be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource of which the application will be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
