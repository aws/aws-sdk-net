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
    /// A summary of the brand.
    /// </summary>
    public partial class BrandSummary
    {
        private string _arn;
        private string _brandId;
        private string _brandName;
        private BrandStatus _brandStatus;
        private DateTime? _createdTime;
        private string _description;
        private DateTime? _lastUpdatedTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the brand.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BrandId. 
        /// <para>
        /// The ID of the QuickSight brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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

        /// <summary>
        /// Gets and sets the property BrandName. 
        /// <para>
        /// The name of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string BrandName
        {
            get { return this._brandName; }
            set { this._brandName = value; }
        }

        // Check to see if BrandName property is set
        internal bool IsSetBrandName()
        {
            return this._brandName != null;
        }

        /// <summary>
        /// Gets and sets the property BrandStatus. 
        /// <para>
        /// The status of the brand.
        /// </para>
        /// </summary>
        public BrandStatus BrandStatus
        {
            get { return this._brandStatus; }
            set { this._brandStatus = value; }
        }

        // Check to see if BrandStatus property is set
        internal bool IsSetBrandStatus()
        {
            return this._brandStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the brand was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the brand.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the brand was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

    }
}