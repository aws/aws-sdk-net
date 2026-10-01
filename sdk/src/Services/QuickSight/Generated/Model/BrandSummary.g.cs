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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A summary of the brand.
    /// </summary>
    public partial class BrandSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the brand.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BrandId. 
        /// <para>
        /// The ID of the Quick brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string BrandId { get; set; }

        /// <summary>
        /// Checks to see if the BrandId property is set.
        /// </summary>
        internal bool IsSetBrandId() => this.BrandId != null;

        /// <summary>
        /// Gets and sets the property BrandName. 
        /// <para>
        /// The name of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string BrandName { get; set; }

        /// <summary>
        /// Checks to see if the BrandName property is set.
        /// </summary>
        internal bool IsSetBrandName() => this.BrandName != null;

        /// <summary>
        /// Gets and sets the property BrandStatus. 
        /// <para>
        /// The status of the brand.
        /// </para>
        /// </summary>
        public BrandStatus BrandStatus { get; set; }

        /// <summary>
        /// Checks to see if the BrandStatus property is set.
        /// </summary>
        internal bool IsSetBrandStatus() => this.BrandStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the brand was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the brand was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;
    }
}
