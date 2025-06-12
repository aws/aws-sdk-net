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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the AddDraftAppVersionResourceMappings operation.
    /// Adds the source of resource-maps to the draft version of an application. During assessment,
    /// Resilience Hub will use these resource-maps to resolve the latest physical ID for
    /// each resource in the application template. For more information about different types
    /// of resources supported by Resilience Hub and how to add them in your application,
    /// see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/how-app-manage.html">Step
    /// 2: How is your application managed?</a> in the Resilience Hub User Guide.
    /// </summary>
    public partial class AddDraftAppVersionResourceMappingsRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private List<ResourceMapping> _resourceMappings = AWSConfigs.InitializeCollections ? new List<ResourceMapping>() : null;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMappings. 
        /// <para>
        /// Mappings used to map logical resources from the template to physical resources. You
        /// can use the mapping type <c>CFN_STACK</c> if the application template uses a logical
        /// stack name. Or you can map individual resources by using the mapping type <c>RESOURCE</c>.
        /// We recommend using the mapping type <c>CFN_STACK</c> if the application is backed
        /// by a CloudFormation stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceMapping> ResourceMappings
        {
            get { return this._resourceMappings; }
            set { this._resourceMappings = value; }
        }

        // Check to see if ResourceMappings property is set
        internal bool IsSetResourceMappings()
        {
            return this._resourceMappings != null && (this._resourceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}