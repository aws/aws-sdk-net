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
    /// Describes and uniquely identifies Kubernetes resources. For example, the compute environment
    /// that a pod runs in or the <c>jobID</c> for a job running in the pod. For more information,
    /// see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/">
    /// Understanding Kubernetes Objects</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksMetadata
    {
        private Dictionary<string, string> _annotations = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Key-value pairs used to attach arbitrary, non-identifying metadata to Kubernetes objects.
        /// Valid annotation keys have two segments: an optional prefix and a name, separated
        /// by a slash (/). 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The prefix is optional and must be 253 characters or less. If specified, the prefix
        /// must be a DNS subdomain− a series of DNS labels separated by dots (.), and it must
        /// end with a slash (/).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name segment is required and must be 63 characters or less. It can include alphanumeric
        /// characters ([a-z0-9A-Z]), dashes (-), underscores (_), and dots (.), but must begin
        /// and end with an alphanumeric character.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Annotation values must be 255 characters or less.
        /// </para>
        ///  </note> 
        /// <para>
        /// Annotations can be added or modified at any time. Each resource can have multiple
        /// annotations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Key-value pairs used to identify, sort, and organize cube resources. Can contain up
        /// to 63 uppercase letters, lowercase letters, numbers, hyphens (-), and underscores
        /// (_). Labels can be added or modified at any time. Each resource can have multiple
        /// labels, but each key must be unique for a given object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the Amazon EKS cluster. In Kubernetes, namespaces provide a mechanism
        /// for isolating groups of resources within a single cluster. Names of resources need
        /// to be unique within a namespace, but not across namespaces. Batch places Batch Job
        /// pods in this namespace. If this field is provided, the value can't be empty or null.
        /// It must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1-63 characters long
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to default
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't start with <c>kube</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must match the following regular expression: <c>^[a-z0-9]([-a-z0-9]*[a-z0-9])?$</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/">Namespaces</a>
        /// in the <i>Kubernetes documentation</i>. This namespace can be different from the <c>kubernetesNamespace</c>
        /// set in the compute environment's <c>EksConfiguration</c>, but must have identical
        /// role-based access control (RBAC) roles as the compute environment's <c>kubernetesNamespace</c>.
        /// For multi-node parallel jobs, the same value must be provided across all the node
        /// ranges.
        /// </para>
        /// </summary>
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