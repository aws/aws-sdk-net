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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceLinkedRole operation.
    /// Creates an IAM role that is linked to a specific Amazon Web Services service. The
    /// service controls the attached policies and when the role can be deleted. This helps
    /// ensure that the service is not broken by an unexpectedly changed or deleted role,
    /// which could put your Amazon Web Services resources into an unknown state. Allowing
    /// the service to control the role helps improve service stability and proper cleanup
    /// when a service and its role are no longer needed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">Using
    /// service-linked roles</a> in the <i>IAM User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// To attach a policy to this service-linked role, you must make the request using the
    /// Amazon Web Services service that depends on this role.
    /// </para>
    /// </summary>
    public partial class CreateServiceLinkedRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _awsServiceName;
        private string _customSuffix;
        private string _description;

        /// <summary>
        /// Gets and sets the property AWSServiceName. 
        /// <para>
        /// The service principal for the Amazon Web Services service to which this role is attached.
        /// You use a string similar to a URL but without the http:// in front. For example: <c>elasticbeanstalk.amazonaws.com</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Service principals are unique and case-sensitive. To find the exact service principal
        /// for your service-linked role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html">Amazon
        /// Web Services services that work with IAM</a> in the <i>IAM User Guide</i>. Look for
        /// the services that have <b>Yes </b>in the <b>Service-Linked Role</b> column. Choose
        /// the <b>Yes</b> link to view the service-linked role documentation for that service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AWSServiceName
        {
            get { return this._awsServiceName; }
            set { this._awsServiceName = value; }
        }

        // Check to see if AWSServiceName property is set
        internal bool IsSetAWSServiceName()
        {
            return this._awsServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSuffix.  
        /// <para>
        /// A string that you provide, which is combined with the service-provided prefix to form
        /// the complete role name. If you make multiple requests for the same service, then you
        /// must supply a different <c>CustomSuffix</c> for each request. Otherwise the request
        /// fails with a duplicate role name error. For example, you could add <c>-1</c> or <c>-debug</c>
        /// to the suffix.
        /// </para>
        ///  
        /// <para>
        /// Some services do not support the <c>CustomSuffix</c> parameter. If you provide an
        /// optional suffix and the operation fails, try the operation again without the suffix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomSuffix
        {
            get { return this._customSuffix; }
            set { this._customSuffix = value; }
        }

        // Check to see if CustomSuffix property is set
        internal bool IsSetCustomSuffix()
        {
            return this._customSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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

    }
}