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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeployment operation.
    /// Initiate a manual deployment of the latest commit in a source code repository or the
    /// latest image in a source image repository to an App Runner service.
    /// 
    ///  
    /// <para>
    /// For a source code repository, App Runner retrieves the commit and builds a Docker
    /// image. For a source image repository, App Runner retrieves the latest Docker image.
    /// In both cases, App Runner then deploys the new image to your service and starts a
    /// new container instance.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous operation. On a successful call, you can use the returned
    /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
    /// </para>
    /// </summary>
    public partial class StartDeploymentRequest : AmazonAppRunnerRequest
    {
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service that you want to manually
        /// deploy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

    }
}