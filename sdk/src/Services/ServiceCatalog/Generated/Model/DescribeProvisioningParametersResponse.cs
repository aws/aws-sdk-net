/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeProvisioningParameters operation.
    /// </summary>
    public partial class DescribeProvisioningParametersResponse : AmazonWebServiceResponse
    {
        private List<ConstraintSummary> _constraintSummaries = new List<ConstraintSummary>();
        private List<ProvisioningArtifactParameter> _provisioningArtifactParameters = new List<ProvisioningArtifactParameter>();
        private List<UsageInstruction> _usageInstructions = new List<UsageInstruction>();

        /// <summary>
        /// Gets and sets the property ConstraintSummaries. 
        /// <para>
        /// The list of constraint summaries that apply to provisioning this product.
        /// </para>
        /// </summary>
        public List<ConstraintSummary> ConstraintSummaries
        {
            get { return this._constraintSummaries; }
            set { this._constraintSummaries = value; }
        }

        // Check to see if ConstraintSummaries property is set
        internal bool IsSetConstraintSummaries()
        {
            return this._constraintSummaries != null && this._constraintSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactParameters. 
        /// <para>
        /// The list of parameters used to successfully provision the product. Each parameter
        /// includes a list of allowable values and additional metadata about each parameter.
        /// </para>
        /// </summary>
        public List<ProvisioningArtifactParameter> ProvisioningArtifactParameters
        {
            get { return this._provisioningArtifactParameters; }
            set { this._provisioningArtifactParameters = value; }
        }

        // Check to see if ProvisioningArtifactParameters property is set
        internal bool IsSetProvisioningArtifactParameters()
        {
            return this._provisioningArtifactParameters != null && this._provisioningArtifactParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Any additional metadata specifically related to the provisioning of the product. For
        /// example, see the <code>Version</code> field of the CloudFormation template.
        /// </para>
        /// </summary>
        public List<UsageInstruction> UsageInstructions
        {
            get { return this._usageInstructions; }
            set { this._usageInstructions = value; }
        }

        // Check to see if UsageInstructions property is set
        internal bool IsSetUsageInstructions()
        {
            return this._usageInstructions != null && this._usageInstructions.Count > 0; 
        }

    }
}