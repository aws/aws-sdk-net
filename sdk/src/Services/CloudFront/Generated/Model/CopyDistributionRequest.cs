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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDistribution operation.
    /// Creates a staging distribution using the configuration of the provided primary distribution.
    /// A staging distribution is a copy of an existing distribution (called the primary distribution)
    /// that you can use in a continuous deployment workflow.
    /// 
    ///  
    /// <para>
    /// After you create a staging distribution, you can use <code>UpdateDistribution</code>
    /// to modify the staging distribution's configuration. Then you can use <code>CreateContinuousDeploymentPolicy</code>
    /// to incrementally move traffic to the staging distribution.
    /// </para>
    /// </summary>
    public partial class CopyDistributionRequest : AmazonCloudFrontRequest
    {
        private string _callerReference;
        private string _ifMatch;
        private string _primaryDistributionId;
        private bool? _staging;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A value that uniquely identifies a request to create a resource. This helps to prevent
        /// CloudFront from creating a duplicate resource if you accidentally resubmit an identical
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The version identifier of the primary distribution whose configuration you are copying.
        /// This is the <code>ETag</code> value returned in the response to <code>GetDistribution</code>
        /// and <code>GetDistributionConfig</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryDistributionId. 
        /// <para>
        /// The identifier of the primary distribution whose configuration you are copying. To
        /// get a distribution ID, use <code>ListDistributions</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrimaryDistributionId
        {
            get { return this._primaryDistributionId; }
            set { this._primaryDistributionId = value; }
        }

        // Check to see if PrimaryDistributionId property is set
        internal bool IsSetPrimaryDistributionId()
        {
            return this._primaryDistributionId != null;
        }

        /// <summary>
        /// Gets and sets the property Staging. 
        /// <para>
        /// The type of distribution that your primary distribution will be copied to. The only
        /// valid value is <code>True</code>, indicating that you are copying to a staging distribution.
        /// </para>
        /// </summary>
        public bool Staging
        {
            get { return this._staging.GetValueOrDefault(); }
            set { this._staging = value; }
        }

        // Check to see if Staging property is set
        internal bool IsSetStaging()
        {
            return this._staging.HasValue; 
        }

    }
}