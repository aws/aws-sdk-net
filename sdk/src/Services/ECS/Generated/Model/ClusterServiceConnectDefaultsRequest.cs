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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Use this parameter to set a default Service Connect namespace. After you set a default
    /// Service Connect namespace, any new services with Service Connect turned on that are
    /// created in the cluster are added as client services in the namespace. This setting
    /// only applies to new services that set the <code>enabled</code> parameter to <code>true</code>
    /// in the <code>ServiceConnectConfiguration</code>. You can set the namespace of each
    /// service individually in the <code>ServiceConnectConfiguration</code> to override this
    /// default parameter.
    /// 
    ///  
    /// <para>
    /// Tasks that run in a namespace can use short names to connect to services in the namespace.
    /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
    /// through a managed proxy container that collects logs and metrics for increased visibility.
    /// Only the tasks that Amazon ECS services create are supported with Service Connect.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ClusterServiceConnectDefaultsRequest
    {
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace name or full Amazon Resource Name (ARN) of the Cloud Map namespace that's
        /// used when you create a service and don't specify a Service Connect configuration.
        /// The namespace name can include up to 1024 characters. The name is case-sensitive.
        /// The name can't include hyphens (-), tilde (~), greater than (&gt;), less than (&lt;),
        /// or slash (/).
        /// </para>
        ///  
        /// <para>
        /// If you enter an existing namespace name or ARN, then that namespace will be used.
        /// Any namespace type is supported. The namespace must be in this account and this Amazon
        /// Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If you enter a new name, a Cloud Map namespace will be created. Amazon ECS creates
        /// a Cloud Map namespace with the "API calls" method of instance discovery only. This
        /// instance discovery method is the "HTTP" namespace type in the Command Line Interface.
        /// Other types of instance discovery aren't used by Service Connect.
        /// </para>
        ///  
        /// <para>
        /// If you update the service with an empty string <code>""</code> for the namespace name,
        /// the cluster configuration for Service Connect is removed. Note that the namespace
        /// will remain in Cloud Map and must be deleted separately.
        /// </para>
        ///  
        /// <para>
        /// For more information about Cloud Map, see <a href="https://docs.aws.amazon.com/">Working
        /// with Services</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}