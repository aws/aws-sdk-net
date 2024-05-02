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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies the configuration of a Kubernetes <c>secret</c> volume. For more information,
    /// see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#secret">secret</a>
    /// in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksSecret
    {
        private bool? _optional;
        private string _secretName;

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Specifies whether the secret or the secret's keys must be defined.
        /// </para>
        /// </summary>
        public bool? Optional
        {
            get { return this._optional; }
            set { this._optional = value; }
        }

        // Check to see if Optional property is set
        internal bool IsSetOptional()
        {
            return this._optional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretName. 
        /// <para>
        /// The name of the secret. The name must be allowed as a DNS subdomain name. For more
        /// information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#dns-subdomain-names">DNS
        /// subdomain names</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretName
        {
            get { return this._secretName; }
            set { this._secretName = value; }
        }

        // Check to see if SecretName property is set
        internal bool IsSetSecretName()
        {
            return this._secretName != null;
        }

    }
}