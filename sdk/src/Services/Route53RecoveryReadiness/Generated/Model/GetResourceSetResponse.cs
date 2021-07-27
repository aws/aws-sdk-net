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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetResourceSet operation.
    /// </summary>
    public partial class GetResourceSetResponse : AmazonWebServiceResponse
    {
        private List<Resource> _resources = new List<Resource>();
        private string _resourceSetArn;
        private string _resourceSetName;
        private string _resourceSetType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Resources. A list of Resource objects
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceSetArn. The arn for the ResourceSet
        /// </summary>
        [AWSProperty(Max=256)]
        public string ResourceSetArn
        {
            get { return this._resourceSetArn; }
            set { this._resourceSetArn = value; }
        }

        // Check to see if ResourceSetArn property is set
        internal bool IsSetResourceSetArn()
        {
            return this._resourceSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSetName. The name of the ResourceSet
        /// </summary>
        [AWSProperty(Max=64)]
        public string ResourceSetName
        {
            get { return this._resourceSetName; }
            set { this._resourceSetName = value; }
        }

        // Check to see if ResourceSetName property is set
        internal bool IsSetResourceSetName()
        {
            return this._resourceSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSetType. AWS Resource Type of the resources in
        /// the ResourceSet
        /// </summary>
        public string ResourceSetType
        {
            get { return this._resourceSetType; }
            set { this._resourceSetType = value; }
        }

        // Check to see if ResourceSetType property is set
        internal bool IsSetResourceSetType()
        {
            return this._resourceSetType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}