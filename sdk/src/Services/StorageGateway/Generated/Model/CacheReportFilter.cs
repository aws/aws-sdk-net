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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A list of filter parameters and associated values that determine which files are included
    /// or excluded from a cache report created by a <c>StartCacheReport</c> request. Multiple
    /// instances of the same filter parameter are combined with an OR operation, while different
    /// parameters are combined with an AND operation.
    /// </summary>
    public partial class CacheReportFilter
    {
        private CacheReportFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The parameter name for a filter that determines which files are included or excluded
        /// from a cache report.
        /// </para>
        ///  
        /// <para>
        ///  <b>Valid Names:</b> 
        /// </para>
        ///  
        /// <para>
        /// UploadFailureReason | UploadState
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CacheReportFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The parameter value for a filter that determines which files are included or excluded
        /// from a cache report.
        /// </para>
        ///  
        /// <para>
        ///  <b>Valid <c>UploadFailureReason</c> Values:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>InaccessibleStorageClass</c> | <c>InvalidObjectState</c> | <c>ObjectMissing</c>
        /// | <c>S3AccessDenied</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Valid <c>UploadState</c> Values:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>FailingUpload</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}