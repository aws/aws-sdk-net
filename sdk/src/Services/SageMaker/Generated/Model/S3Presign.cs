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
    /// This object defines the access restrictions to Amazon S3 resources that are included
    /// in custom worker task templates using the Liquid filter, <c>grant_read_access</c>.
    /// 
    ///  
    /// <para>
    /// To learn more about how custom templates are created, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-custom-templates.html">Create
    /// custom worker task templates</a>.
    /// </para>
    /// </summary>
    public partial class S3Presign
    {
        private IamPolicyConstraints _iamPolicyConstraints;

        /// <summary>
        /// Gets and sets the property IamPolicyConstraints. 
        /// <para>
        /// Use this parameter to specify the allowed request source. Possible sources are either
        /// <c>SourceIp</c> or <c>VpcSourceIp</c>.
        /// </para>
        /// </summary>
        public IamPolicyConstraints IamPolicyConstraints
        {
            get { return this._iamPolicyConstraints; }
            set { this._iamPolicyConstraints = value; }
        }

        // Check to see if IamPolicyConstraints property is set
        internal bool IsSetIamPolicyConstraints()
        {
            return this._iamPolicyConstraints != null;
        }

    }
}