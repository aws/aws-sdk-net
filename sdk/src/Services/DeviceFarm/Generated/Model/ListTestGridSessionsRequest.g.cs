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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestGridSessions operation. Retrieves a list
    /// of sessions for a <a>TestGridProject</a>.
    /// </summary>
    public partial class ListTestGridSessionsRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Return only sessions created after this time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Return only sessions created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimeAfter. 
        /// <para>
        /// Return only sessions that ended after this time.
        /// </para>
        /// </summary>
        public DateTime? EndTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeAfter property is set.
        /// </summary>
        internal bool IsSetEndTimeAfter() => this.EndTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// Return only sessions that ended before this time.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBefore property is set.
        /// </summary>
        internal bool IsSetEndTimeBefore() => this.EndTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResult. 
        /// <para>
        /// Return only this many results at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// Checks to see if the MaxResult property is set.
        /// </summary>
        internal bool IsSetMaxResult() => this.MaxResult.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// ARN of a <a>TestGridProject</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Return only sessions in this state.
        /// </para>
        /// </summary>
        public TestGridSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
