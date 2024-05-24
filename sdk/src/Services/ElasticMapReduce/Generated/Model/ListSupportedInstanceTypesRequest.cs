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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListSupportedInstanceTypes operation.
    /// A list of the instance types that Amazon EMR supports. You can filter the list by
    /// Amazon Web Services Region and Amazon EMR release.
    /// </summary>
    public partial class ListSupportedInstanceTypesRequest : AmazonElasticMapReduceRequest
    {
        private string _marker;
        private string _releaseLabel;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that marks the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label determines the <a href="https://docs.aws.amazon.com/emr/latest/ReleaseGuide/emr-release-app-versions-6.x.html">versions
        /// of open-source application packages</a> that Amazon EMR has installed on the cluster.
        /// Release labels are in the format <c>emr-x.x.x</c>, where x.x.x is an Amazon EMR release
        /// number such as <c>emr-6.10.0</c>. For more information about Amazon EMR releases and
        /// their included application versions and features, see the <i> <a href="https://docs.aws.amazon.com/emr/latest/ReleaseGuide/emr-release-components.html">Amazon
        /// EMR Release Guide</a> </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

    }
}