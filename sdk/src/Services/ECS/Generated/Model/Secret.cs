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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object representing the secret to expose to your container. Secrets can be exposed
    /// to a container in the following ways:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// To inject sensitive data into your containers as environment variables, use the <c>secrets</c>
    /// container definition parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To reference sensitive information in the log configuration of a container, use the
    /// <c>secretOptions</c> container definition parameter.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
    /// sensitive data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class Secret
    {
        private string _name;
        private string _valueFrom;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ValueFrom. 
        /// <para>
        /// The secret to expose to the container. The supported values are either the full ARN
        /// of the Secrets Manager secret or the full ARN of the parameter in the SSM Parameter
        /// Store.
        /// </para>
        ///  
        /// <para>
        /// For information about the require Identity and Access Management permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data-secrets.html#secrets-iam">Required
        /// IAM permissions for Amazon ECS secrets</a> (for Secrets Manager) or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data-parameters.html">Required
        /// IAM permissions for Amazon ECS secrets</a> (for Systems Manager Parameter store) in
        /// the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the SSM Parameter Store parameter exists in the same Region as the task you're
        /// launching, then you can use either the full ARN or name of the parameter. If the parameter
        /// exists in a different Region, then the full ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ValueFrom
        {
            get { return this._valueFrom; }
            set { this._valueFrom = value; }
        }

        // Check to see if ValueFrom property is set
        internal bool IsSetValueFrom()
        {
            return this._valueFrom != null;
        }

    }
}