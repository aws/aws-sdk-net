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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkforce operation.
    /// Use this operation to delete a workforce.
    /// 
    ///  
    /// <para>
    /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
    /// already exists, use this operation to delete the existing workforce and then use <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateWorkforce.html">CreateWorkforce</a>
    /// to create a new workforce.
    /// </para>
    ///  <important> 
    /// <para>
    /// If a private workforce contains one or more work teams, you must use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteWorkteam.html">DeleteWorkteam</a>
    /// operation to delete all work teams before you delete the workforce. If you try to
    /// delete a workforce that contains one or more work teams, you will receive a <c>ResourceInUse</c>
    /// error.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteWorkforceRequest : AmazonSageMakerRequest
    {
        private string _workforceName;

        /// <summary>
        /// Gets and sets the property WorkforceName. 
        /// <para>
        /// The name of the workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WorkforceName
        {
            get { return this._workforceName; }
            set { this._workforceName = value; }
        }

        // Check to see if WorkforceName property is set
        internal bool IsSetWorkforceName()
        {
            return this._workforceName != null;
        }

    }
}