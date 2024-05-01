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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the StopSolutionVersionCreation operation.
    /// Stops creating a solution version that is in a state of CREATE_PENDING or CREATE IN_PROGRESS.
    /// 
    /// 
    ///  
    /// <para>
    /// Depending on the current state of the solution version, the solution version state
    /// changes as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE_PENDING &gt; CREATE_STOPPED
    /// </para>
    ///  
    /// <para>
    /// or
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATE_IN_PROGRESS &gt; CREATE_STOPPING &gt; CREATE_STOPPED
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You are billed for all of the training completed up until you stop the solution version
    /// creation. You cannot resume creating a solution version once it has been stopped.
    /// </para>
    /// </summary>
    public partial class StopSolutionVersionCreationRequest : AmazonPersonalizeRequest
    {
        private string _solutionVersionArn;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version you want to stop creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

    }
}