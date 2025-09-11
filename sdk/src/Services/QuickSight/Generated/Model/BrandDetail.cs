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
    /// The details of the brand.
    /// </summary>
    public partial class BrandDetail
    {
        private string _arn;
        private string _brandId;
        private BrandStatus _brandStatus;
        private DateTime? _createdTime;
        private List<string> _errors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdatedTime;
        private Logo _logo;
        private string _versionId;
        private BrandVersionStatus _versionStatus;

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
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors that occurred during the most recent brand operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time the brand was updated.
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

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        /// The logo details.
        /// </para>
        /// </summary>
        public Logo Logo
        {
            get { return this._logo; }
            set { this._logo = value; }
        }

        // Check to see if Logo property is set
        internal bool IsSetLogo()
        {
            return this._logo != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// The status of the version.
        /// </para>
        /// </summary>
        public BrandVersionStatus VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }

        // Check to see if VersionStatus property is set
        internal bool IsSetVersionStatus()
        {
            return this._versionStatus != null;
        }

    }
}