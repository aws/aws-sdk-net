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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeTypeRegistration operation.
    /// </summary>
    public partial class DescribeTypeRegistrationResponse : AmazonWebServiceResponse
    {
        private string _description;
        private RegistrationStatus _progressStatus;
        private string _typeArn;
        private string _typeVersionArn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the extension registration request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressStatus. 
        /// <para>
        /// The current status of the extension registration request.
        /// </para>
        /// </summary>
        public RegistrationStatus ProgressStatus
        {
            get { return this._progressStatus; }
            set { this._progressStatus = value; }
        }

        // Check to see if ProgressStatus property is set
        internal bool IsSetProgressStatus()
        {
            return this._progressStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension being registered.
        /// </para>
        ///  
        /// <para>
        /// For registration requests with a <c>ProgressStatus</c> of other than <c>COMPLETE</c>,
        /// this will be <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this specific version of the extension being registered.
        /// </para>
        ///  
        /// <para>
        /// For registration requests with a <c>ProgressStatus</c> of other than <c>COMPLETE</c>,
        /// this will be <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeVersionArn
        {
            get { return this._typeVersionArn; }
            set { this._typeVersionArn = value; }
        }

        // Check to see if TypeVersionArn property is set
        internal bool IsSetTypeVersionArn()
        {
            return this._typeVersionArn != null;
        }

    }
}