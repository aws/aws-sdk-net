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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDistributionConfiguration operation.
    /// Updates a new distribution configuration. Distribution configurations define and configure
    /// the outputs of your pipeline.
    /// </summary>
    public partial class UpdateDistributionConfigurationRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _description;
        private string _distributionConfigurationArn;
        private List<Distribution> _distributions = new List<Distribution>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token of the distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration that you want to
        /// update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionConfigurationArn
        {
            get { return this._distributionConfigurationArn; }
            set { this._distributionConfigurationArn = value; }
        }

        // Check to see if DistributionConfigurationArn property is set
        internal bool IsSetDistributionConfigurationArn()
        {
            return this._distributionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Distributions. 
        /// <para>
        /// The distributions of the distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Distribution> Distributions
        {
            get { return this._distributions; }
            set { this._distributions = value; }
        }

        // Check to see if Distributions property is set
        internal bool IsSetDistributions()
        {
            return this._distributions != null && this._distributions.Count > 0; 
        }

    }
}