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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the AddDraftAppVersionResourceMappings operation.
    /// Adds the resource mapping for the draft application version. You can also update an
    /// existing resource mapping to a new physical resource.
    /// </summary>
    public partial class AddDraftAppVersionResourceMappingsRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private List<ResourceMapping> _resourceMappings = new List<ResourceMapping>();

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
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
        /// can use the mapping type <code>CFN_STACK</code> if the application template uses a
        /// logical stack name. Or you can map individual resources by using the mapping type
        /// <code>RESOURCE</code>. We recommend using the mapping type <code>CFN_STACK</code>
        /// if the application is backed by a CloudFormation stack.
        /// </para>
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
            return this._resourceMappings != null && this._resourceMappings.Count > 0; 
        }

    }
}