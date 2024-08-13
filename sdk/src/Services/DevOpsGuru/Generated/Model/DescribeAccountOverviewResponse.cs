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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountOverview operation.
    /// </summary>
    public partial class DescribeAccountOverviewResponse : AmazonWebServiceResponse
    {
        private long? _meanTimeToRecoverInMilliseconds;
        private int? _proactiveInsights;
        private int? _reactiveInsights;

        /// <summary>
        /// Gets and sets the property MeanTimeToRecoverInMilliseconds. 
        /// <para>
        ///  The Mean Time to Recover (MTTR) for all closed insights that were created during
        /// the time range passed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? MeanTimeToRecoverInMilliseconds
        {
            get { return this._meanTimeToRecoverInMilliseconds; }
            set { this._meanTimeToRecoverInMilliseconds = value; }
        }

        // Check to see if MeanTimeToRecoverInMilliseconds property is set
        internal bool IsSetMeanTimeToRecoverInMilliseconds()
        {
            return this._meanTimeToRecoverInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open proactive insights in your Amazon Web
        /// Services account that were created during the time range passed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProactiveInsights
        {
            get { return this._proactiveInsights; }
            set { this._proactiveInsights = value; }
        }

        // Check to see if ProactiveInsights property is set
        internal bool IsSetProactiveInsights()
        {
            return this._proactiveInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open reactive insights in your Amazon Web
        /// Services account that were created during the time range passed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReactiveInsights
        {
            get { return this._reactiveInsights; }
            set { this._reactiveInsights = value; }
        }

        // Check to see if ReactiveInsights property is set
        internal bool IsSetReactiveInsights()
        {
            return this._reactiveInsights.HasValue; 
        }

    }
}