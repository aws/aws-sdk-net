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
    /// Container for the parameters to the TestType operation.
    /// Tests a registered extension to make sure it meets all necessary requirements for
    /// being published in the CloudFormation registry.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For resource types, this includes passing all contracts tests defined for the type.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For modules, this includes determining if the module's model meets all necessary requirements.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-testing">Testing
    /// your public extension before publishing</a> in the <i>CloudFormation Command Line
    /// Interface (CLI) User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you don't specify a version, CloudFormation uses the default version of the extension
    /// in your account and Region for testing.
    /// </para>
    ///  
    /// <para>
    /// To perform testing, CloudFormation assumes the execution role specified when the type
    /// was registered. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
    /// </para>
    ///  
    /// <para>
    /// Once you've initiated testing on an extension using <c>TestType</c>, you can pass
    /// the returned <c>TypeVersionArn</c> into <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>
    /// to monitor the current test status and test status description for the extension.
    /// </para>
    ///  
    /// <para>
    /// An extension must have a test status of <c>PASSED</c> before it can be published.
    /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-publish.html">Publishing
    /// extensions to make them available for public use</a> in the <i>CloudFormation Command
    /// Line Interface (CLI) User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TestTypeRequest : AmazonCloudFormationRequest
    {
        private string _arn;
        private string _logDeliveryBucket;
        private ThirdPartyType _type;
        private string _typeName;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryBucket. 
        /// <para>
        /// The S3 bucket to which CloudFormation delivers the contract test execution logs.
        /// </para>
        ///  
        /// <para>
        /// CloudFormation delivers the logs by the time contract testing has completed and the
        /// extension has been assigned a test type status of <c>PASSED</c> or <c>FAILED</c>.
        /// </para>
        ///  
        /// <para>
        /// The user calling <c>TestType</c> must be able to access items in the specified S3
        /// bucket. Specifically, the user needs the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GetObject</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PutObject</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazons3.html">Actions,
        /// Resources, and Condition Keys for Amazon S3</a> in the <i>Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string LogDeliveryBucket
        {
            get { return this._logDeliveryBucket; }
            set { this._logDeliveryBucket = value; }
        }

        // Check to see if LogDeliveryBucket property is set
        internal bool IsSetLogDeliveryBucket()
        {
            return this._logDeliveryBucket != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the extension to test.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        public ThirdPartyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension to test.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version of the extension to test.
        /// </para>
        ///  
        /// <para>
        /// You can specify the version id with either <c>Arn</c>, or with <c>TypeName</c> and
        /// <c>Type</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a version, CloudFormation uses the default version of the extension
        /// in this account and Region for testing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}