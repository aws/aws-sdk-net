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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeRestApi operation. Invokes the Apache Airflow
    /// REST API on the webserver with the specified inputs. To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/access-mwaa-apache-airflow-rest-api.html">Using
    /// the Apache Airflow REST API</a>
    /// </summary>
    public partial class InvokeRestApiRequest : AmazonMWAARequest
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body for the Apache Airflow REST API call, provided as a JSON object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => !this.Body.IsNull();

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The HTTP method used for making Airflow REST API calls. For example, <c>POST</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RestApiMethod Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon MWAA environment. For example, <c>MyMWAAEnvironment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The Apache Airflow REST API endpoint path to be called. For example, <c>/dags/123456/clearTaskInstances</c>.
        /// For more information, see <a href="https://airflow.apache.org/docs/apache-airflow/stable/stable-rest-api-ref.html">Apache
        /// Airflow API</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// Query parameters to be included in the Apache Airflow REST API call, provided as a
        /// JSON object. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document QueryParameters { get; set; }

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => !this.QueryParameters.IsNull();
    }
}
