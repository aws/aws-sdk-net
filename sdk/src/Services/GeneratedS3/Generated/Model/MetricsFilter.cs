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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies a metrics configuration filter. The metrics configuration only includes
    /// objects that meet the filter's criteria. A filter must be a prefix, an object tag,
    /// an access point ARN, or a conjunction (MetricsAndOperator). For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketMetricsConfiguration.html">PutBucketMetricsConfiguration</a>.
    /// </summary>
    public partial class MetricsFilter
    {
        private string _accessPointArn;
        private MetricsAndOperator _and;
        private string _prefix;
        private Tag _tag;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The access point ARN used when evaluating a metrics filter.
        /// </para>
        /// </summary>
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A conjunction (logical AND) of predicates, which is used in evaluating a metrics filter.
        /// The operator must have at least two predicates, and an object must match all of the
        /// predicates in order for the filter to apply.
        /// </para>
        /// </summary>
        public MetricsAndOperator And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix used when evaluating a metrics filter.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// The tag used when evaluating a metrics filter.
        /// </para>
        /// </summary>
        public Tag Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return this._tag != null;
        }

    }
}