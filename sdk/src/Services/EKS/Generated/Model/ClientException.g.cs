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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// These errors are usually caused by a client action. Actions can include using an action
    /// or resource on behalf of an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html">IAM
    /// principal</a> that doesn't have permissions to use the action or resource or specifying
    /// an identifier that is not valid.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ClientException : AmazonEKSException
    {
        /// <summary>
        /// Default constructor for ClientException
        /// message.
        /// </summary>
        public ClientException() : base() { }

        /// <summary>
        /// Constructs a new ClientException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ClientException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ClientException
        /// </summary>
        public ClientException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ClientException
        /// </summary>
        public ClientException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ClientException
        /// </summary>
        public ClientException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ClientException
        /// </summary>
        public ClientException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The Amazon EKS add-on name associated with the exception.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The Amazon EKS cluster associated with the exception.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The Amazon EKS managed node group associated with the exception.
        /// </para>
        /// </summary>
        public string NodegroupName { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupName property is set.
        /// </summary>
        internal bool IsSetNodegroupName() => this.NodegroupName != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Amazon EKS subscription ID with the exception.
        /// </para>
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ClientException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ClientException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.AddonName = (string)info.GetValue("AddonName", typeof(string));
            this.ClusterName = (string)info.GetValue("ClusterName", typeof(string));
            this.NodegroupName = (string)info.GetValue("NodegroupName", typeof(string));
            this.SubscriptionId = (string)info.GetValue("SubscriptionId", typeof(string));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("AddonName", this.AddonName);
            info.AddValue("ClusterName", this.ClusterName);
            info.AddValue("NodegroupName", this.NodegroupName);
            info.AddValue("SubscriptionId", this.SubscriptionId);
        }
#endif
    }
}
