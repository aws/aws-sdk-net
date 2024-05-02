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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDistributionBundle operation.
    /// Updates the bundle of your Amazon Lightsail content delivery network (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// A distribution bundle specifies the monthly network transfer quota and monthly cost
    /// of your distribution.
    /// </para>
    ///  
    /// <para>
    /// Update your distribution's bundle if your distribution is going over its monthly network
    /// transfer quota and is incurring an overage fee.
    /// </para>
    ///  
    /// <para>
    /// You can update your distribution's bundle only one time within your monthly Amazon
    /// Web Services billing cycle. To determine if you can update your distribution's bundle,
    /// use the <c>GetDistributions</c> action. The <c>ableToUpdateBundle</c> parameter in
    /// the result will indicate whether you can currently update your distribution's bundle.
    /// </para>
    /// </summary>
    public partial class UpdateDistributionBundleRequest : AmazonLightsailRequest
    {
        private string _bundleId;
        private string _distributionName;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle ID of the new bundle to apply to your distribution.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributionBundles</c> action to get a list of distribution bundle
        /// IDs that you can specify.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionName. 
        /// <para>
        /// The name of the distribution for which to update the bundle.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributions</c> action to get a list of distribution names that you
        /// can specify.
        /// </para>
        /// </summary>
        public string DistributionName
        {
            get { return this._distributionName; }
            set { this._distributionName = value; }
        }

        // Check to see if DistributionName property is set
        internal bool IsSetDistributionName()
        {
            return this._distributionName != null;
        }

    }
}