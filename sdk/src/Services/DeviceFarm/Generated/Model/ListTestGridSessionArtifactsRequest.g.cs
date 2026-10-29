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
    /// Container for the parameters to the ListTestGridSessionArtifacts operation. Retrieves
    /// a list of artifacts created during the session.
    /// </summary>
    public partial class ListTestGridSessionArtifactsRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResult. 
        /// <para>
        /// The maximum number of results to be returned by a request.
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
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The ARN of a <a>TestGridSession</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Limit results to a specified type of artifact.
        /// </para>
        /// </summary>
        public TestGridSessionArtifactCategory Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
