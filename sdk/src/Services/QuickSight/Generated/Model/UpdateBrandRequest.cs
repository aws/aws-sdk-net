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
    /// Container for the parameters to the UpdateBrand operation.
    /// Updates a brand.
    /// </summary>
    public partial class UpdateBrandRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private BrandDefinition _brandDefinition;
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
        /// Gets and sets the property BrandDefinition. 
        /// <para>
        /// The definition of the brand.
        /// </para>
        /// </summary>
        public BrandDefinition BrandDefinition
        {
            get { return this._brandDefinition; }
            set { this._brandDefinition = value; }
        }

        // Check to see if BrandDefinition property is set
        internal bool IsSetBrandDefinition()
        {
            return this._brandDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property BrandId. 
        /// <para>
        /// The ID of the Amazon QuickSight brand.
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