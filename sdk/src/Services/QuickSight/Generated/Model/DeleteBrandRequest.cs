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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBrand operation.
    /// <important> 
    /// <para>
    /// This API permanently deletes the specified QuickSight brand. When you delete a brand:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The brand and all its associated branding elements are permanently removed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any applications or dashboards using this brand will revert to default styling
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This action cannot be undone through the API
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Before proceeding:</b> Verify that the brand is no longer needed and consider
    /// the impact on any applications currently using this brand.
    /// </para>
    ///  </important> 
    /// <para>
    /// Deletes an QuickSight brand.
    /// </para>
    /// </summary>
    public partial class DeleteBrandRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _brandId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property BrandId. 
        /// <para>
        /// The ID of the QuickSight brand.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string BrandId
        {
            get { return this._brandId; }
            set { this._brandId = value; }
        }

        // Check to see if BrandId property is set
        internal bool IsSetBrandId()
        {
            return this._brandId != null;
        }

    }
}