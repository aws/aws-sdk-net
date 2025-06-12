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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
    /// At least one of your specified cluster subnets is in an Availability Zone that does
    /// not support Amazon EKS. The exception output specifies the supported Availability
    /// Zones for your account, from which you can choose subnets for your cluster.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class UnsupportedAvailabilityZoneException : AmazonEKSException
    {
        private string _clusterName;
        private string _nodegroupName;
        private List<string> _validZones = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Constructs a new UnsupportedAvailabilityZoneException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public UnsupportedAvailabilityZoneException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of UnsupportedAvailabilityZoneException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public UnsupportedAvailabilityZoneException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of UnsupportedAvailabilityZoneException
        /// </summary>
        /// <param name="innerException"></param>
        public UnsupportedAvailabilityZoneException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of UnsupportedAvailabilityZoneException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public UnsupportedAvailabilityZoneException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of UnsupportedAvailabilityZoneException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public UnsupportedAvailabilityZoneException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the UnsupportedAvailabilityZoneException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected UnsupportedAvailabilityZoneException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.ClusterName = (string)info.GetValue("ClusterName", typeof(string));
            this.NodegroupName = (string)info.GetValue("NodegroupName", typeof(string));
            this.ValidZones = (List<string>)info.GetValue("ValidZones", typeof(List<string>));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ClusterName", this.ClusterName);
            info.AddValue("NodegroupName", this.NodegroupName);
            info.AddValue("ValidZones", this.ValidZones);
        }
#endif

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The Amazon EKS cluster associated with the exception.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The Amazon EKS managed node group associated with the exception.
        /// </para>
        /// </summary>
        public string NodegroupName
        {
            get { return this._nodegroupName; }
            set { this._nodegroupName = value; }
        }

        // Check to see if NodegroupName property is set
        internal bool IsSetNodegroupName()
        {
            return this._nodegroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ValidZones. 
        /// <para>
        /// The supported Availability Zones for your account. Choose subnets in these Availability
        /// Zones for your cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidZones
        {
            get { return this._validZones; }
            set { this._validZones = value; }
        }

        // Check to see if ValidZones property is set
        internal bool IsSetValidZones()
        {
            return this._validZones != null && (this._validZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}