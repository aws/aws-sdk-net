/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object representing the secret to expose to your container. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
    /// Sensitive Data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class Secret
    {
        private string _name;
        private string _valueFrom;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The value to set as the environment variable on the container.
        /// </para>
        /// </summary>
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
        /// The secret to expose to the container. If your task is using the EC2 launch type,
        /// then supported values are either the full ARN of the AWS Secrets Manager secret or
        /// the full ARN of the parameter in the AWS Systems Manager Parameter Store. If your
        /// task is using the Fargate launch type, then the only supported value is the full ARN
        /// of the parameter in the AWS Systems Manager Parameter Store.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the AWS Systems Manager Parameter Store parameter exists in the same Region as
        /// the task you are launching, then you can use either the full ARN or name of the parameter.
        /// If the parameter exists in a different Region, then the full ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
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