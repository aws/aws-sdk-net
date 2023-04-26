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
    /// Defines a logical resource identifier.
    /// </summary>
    public partial class LogicalResourceId
    {
        private string _eksSourceName;
        private string _identifier;
        private string _logicalStackName;
        private string _resourceGroupName;
        private string _terraformSourceName;

        /// <summary>
        /// Gets and sets the property EksSourceName. 
        /// <para>
        /// The name of the Amazon Elastic Kubernetes Service cluster and namespace this resource
        /// belongs to.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter accepts values in "eks-cluster/namespace" format.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EksSourceName
        {
            get { return this._eksSourceName; }
            set { this._eksSourceName = value; }
        }

        // Check to see if EksSourceName property is set
        internal bool IsSetEksSourceName()
        {
            return this._eksSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalStackName. 
        /// <para>
        /// The name of the CloudFormation stack this resource belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogicalStackName
        {
            get { return this._logicalStackName; }
            set { this._logicalStackName = value; }
        }

        // Check to see if LogicalStackName property is set
        internal bool IsSetLogicalStackName()
        {
            return this._logicalStackName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group that this resource belongs to.
        /// </para>
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TerraformSourceName. 
        /// <para>
        ///  The name of the Terraform S3 state file this resource belongs to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TerraformSourceName
        {
            get { return this._terraformSourceName; }
            set { this._terraformSourceName = value; }
        }

        // Check to see if TerraformSourceName property is set
        internal bool IsSetTerraformSourceName()
        {
            return this._terraformSourceName != null;
        }

    }
}