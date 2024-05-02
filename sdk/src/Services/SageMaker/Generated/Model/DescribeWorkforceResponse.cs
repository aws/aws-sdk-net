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
    /// This is the response object from the DescribeWorkforce operation.
    /// </summary>
    public partial class DescribeWorkforceResponse : AmazonWebServiceResponse
    {
        private Workforce _workforce;

        /// <summary>
        /// Gets and sets the property Workforce. 
        /// <para>
        /// A single private workforce, which is automatically created when you create your first
        /// private work team. You can create one private work force in each Amazon Web Services
        /// Region. By default, any workforce-related API operation used in a specific region
        /// will apply to the workforce created in that region. To learn how to create a private
        /// workforce, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">Create
        /// a Private Workforce</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Workforce Workforce
        {
            get { return this._workforce; }
            set { this._workforce = value; }
        }

        // Check to see if Workforce property is set
        internal bool IsSetWorkforce()
        {
            return this._workforce != null;
        }

    }
}