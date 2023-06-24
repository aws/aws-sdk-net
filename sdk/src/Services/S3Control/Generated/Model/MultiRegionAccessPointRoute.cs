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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A structure for a Multi-Region Access Point that indicates where Amazon S3 traffic
    /// can be routed. Routes can be either active or passive. Active routes can process Amazon
    /// S3 requests through the Multi-Region Access Point, but passive routes are not eligible
    /// to process Amazon S3 requests. 
    /// 
    ///  
    /// <para>
    /// Each route contains the Amazon S3 bucket name and the Amazon Web Services Region that
    /// the bucket is located in. The route also includes the <code>TrafficDialPercentage</code>
    /// value, which shows whether the bucket and Region are active (indicated by a value
    /// of <code>100</code>) or passive (indicated by a value of <code>0</code>).
    /// </para>
    /// </summary>
    public partial class MultiRegionAccessPointRoute
    {
        private string _bucket;
        private string _region;
        private int? _trafficDialPercentage;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket for which you'll submit a routing configuration change.
        /// Either the <code>Bucket</code> or the <code>Region</code> value must be provided.
        /// If both are provided, the bucket must be in the specified Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region to which you'll be submitting a routing configuration
        /// change. Either the <code>Bucket</code> or the <code>Region</code> value must be provided.
        /// If both are provided, the bucket must be in the specified Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficDialPercentage. 
        /// <para>
        /// The traffic state for the specified bucket or Amazon Web Services Region. 
        /// </para>
        ///  
        /// <para>
        /// A value of <code>0</code> indicates a passive state, which means that no new traffic
        /// will be routed to the Region. 
        /// </para>
        ///  
        /// <para>
        /// A value of <code>100</code> indicates an active state, which means that traffic will
        /// be routed to the specified Region. 
        /// </para>
        ///  
        /// <para>
        /// When the routing configuration for a Region is changed from active to passive, any
        /// in-progress operations (uploads, copies, deletes, and so on) to the formerly active
        /// Region will continue to run to until a final success or failure status is reached.
        /// </para>
        ///  
        /// <para>
        /// If all Regions in the routing configuration are designated as passive, you'll receive
        /// an <code>InvalidRequest</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int TrafficDialPercentage
        {
            get { return this._trafficDialPercentage.GetValueOrDefault(); }
            set { this._trafficDialPercentage = value; }
        }

        // Check to see if TrafficDialPercentage property is set
        internal bool IsSetTrafficDialPercentage()
        {
            return this._trafficDialPercentage.HasValue; 
        }

    }
}