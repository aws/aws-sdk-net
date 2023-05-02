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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeAppVersionTemplate operation.
    /// </summary>
    public partial class DescribeAppVersionTemplateResponse : AmazonWebServiceResponse
    {
        private string _appArn;
        private string _appTemplateBody;
        private string _appVersion;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppTemplateBody. 
        /// <para>
        /// A JSON string that provides information about your application structure. To learn
        /// more about the <code>appTemplateBody</code> template, see the sample template provided
        /// in the <i>Examples</i> section.
        /// </para>
        ///  
        /// <para>
        /// The <code>appTemplateBody</code> JSON string has the following structure:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>resources</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// The list of logical resources that must be included in the Resilience Hub application.
        /// </para>
        ///  
        /// <para>
        /// Type: Array
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the resources that you want to exclude.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each <code>resources</code> array item includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>logicalResourceId</code> </i> 
        /// </para>
        ///  
        /// <para>
        /// The logical identifier of the resource.
        /// </para>
        ///  
        /// <para>
        /// Type: Object
        /// </para>
        ///  
        /// <para>
        /// Each <code>logicalResourceId</code> object includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>identifier</code> 
        /// </para>
        ///  
        /// <para>
        /// The identifier of the resource.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>logicalStackName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the CloudFormation stack this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceGroupName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the resource group this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terraformSourceName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the Terraform S3 state file this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>eksSourceName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the Amazon Elastic Kubernetes Service cluster and namespace this resource
        /// belongs to.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter accepts values in "eks-cluster/namespace" format.
        /// </para>
        ///  </note> 
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i> <code>type</code> </i> 
        /// </para>
        ///  
        /// <para>
        /// The type of resource.
        /// </para>
        ///  
        /// <para>
        /// Type: string
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>name</code> </i> 
        /// </para>
        ///  
        /// <para>
        /// The name of the resource.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>additionalInfo</code> 
        /// </para>
        ///  
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <code>additionalInfo</code> through the Resilience Hub console rather
        /// than using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <code>"failover-regions"</code> 
        /// </para>
        ///  
        /// <para>
        /// Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code>
        /// 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <code>appComponents</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// The list of Application Components that this resource belongs to. If an Application
        /// Component is not part of the Resilience Hub application, it will be added.
        /// </para>
        ///  
        /// <para>
        /// Type: Array
        /// </para>
        ///  
        /// <para>
        /// Each <code>appComponents</code> array item includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>name</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the Application Component.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> 
        /// </para>
        ///  
        /// <para>
        /// The type of Application Component. For more information about the types of Application
        /// Component, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/AppComponent.grouping.html">Grouping
        /// resources in an AppComponent</a>.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceNames</code> 
        /// </para>
        ///  
        /// <para>
        /// The list of included resources that are assigned to the Application Component.
        /// </para>
        ///  
        /// <para>
        /// Type: Array of strings
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>additionalInfo</code> 
        /// </para>
        ///  
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <code>additionalInfo</code> through the Resilience Hub console rather
        /// than using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <code>"failover-regions"</code> 
        /// </para>
        ///  
        /// <para>
        /// Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code>
        /// 
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <code>excludedResources</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// The list of logical resource identifiers to be excluded from the application.
        /// </para>
        ///  
        /// <para>
        /// Type: Array
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the resources that you want to include.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each <code>excludedResources</code> array item includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>logicalResourceIds</code> </i> 
        /// </para>
        ///  
        /// <para>
        /// The logical identifier of the resource.
        /// </para>
        ///  
        /// <para>
        /// Type: Object
        /// </para>
        ///  <note> 
        /// <para>
        /// You can configure only one of the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>logicalStackName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceGroupName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terraformSourceName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>eksSourceName</code> 
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// Each <code>logicalResourceIds</code> object includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>identifier</code> 
        /// </para>
        ///  
        /// <para>
        /// The identifier of the resource.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>logicalStackName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the CloudFormation stack this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceGroupName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the resource group this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terraformSourceName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the Terraform S3 state file this resource belongs to.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>eksSourceName</code> 
        /// </para>
        ///  
        /// <para>
        /// The name of the Amazon Elastic Kubernetes Service cluster and namespace this resource
        /// belongs to.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter accepts values in "eks-cluster/namespace" format.
        /// </para>
        ///  </note> 
        /// <para>
        /// Type: String
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <code>version</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// The Resilience Hub application version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>additionalInfo</code> 
        /// </para>
        ///  
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <code>additionalInfo</code> through the Resilience Hub console rather
        /// than using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <code>"failover-regions"</code> 
        /// </para>
        ///  
        /// <para>
        /// Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code>
        /// 
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=204800)]
        public string AppTemplateBody
        {
            get { return this._appTemplateBody; }
            set { this._appTemplateBody = value; }
        }

        // Check to see if AppTemplateBody property is set
        internal bool IsSetAppTemplateBody()
        {
            return this._appTemplateBody != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

    }
}