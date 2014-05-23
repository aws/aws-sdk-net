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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the SwapEnvironmentCNAMEs operation.
    /// Swaps the CNAMEs of two environments.
    /// </summary>
    public partial class SwapEnvironmentCNAMEsRequest : AmazonWebServiceRequest
    {
        private string _destinationEnvironmentId;
        private string _destinationEnvironmentName;
        private string _sourceEnvironmentId;
        private string _sourceEnvironmentName;


        /// <summary>
        /// Gets and sets the property DestinationEnvironmentId. 
        /// <para>
        ///          The ID of the destination environment.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify at least the <code>DestinationEnvironmentID</code>
        /// or the <code>DestinationEnvironmentName</code>.          You may also specify both.
        ///         You must specify the <code>SourceEnvironmentId</code> with the <code>DestinationEnvironmentId</code>.
        ///      
        /// </para>
        /// </summary>
        public string DestinationEnvironmentId
        {
            get { return this._destinationEnvironmentId; }
            set { this._destinationEnvironmentId = value; }
        }


        /// <summary>
        /// Sets the DestinationEnvironmentId property
        /// </summary>
        /// <param name="destinationEnvironmentId">The value to set for the DestinationEnvironmentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SwapEnvironmentCNAMEsRequest WithDestinationEnvironmentId(string destinationEnvironmentId)
        {
            this._destinationEnvironmentId = destinationEnvironmentId;
            return this;
        }

        // Check to see if DestinationEnvironmentId property is set
        internal bool IsSetDestinationEnvironmentId()
        {
            return this._destinationEnvironmentId != null;
        }


        /// <summary>
        /// Gets and sets the property DestinationEnvironmentName. 
        /// <para>
        ///          The name of the destination environment.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify at least the <code>DestinationEnvironmentID</code>
        /// or the <code>DestinationEnvironmentName</code>.          You may also specify both.
        /// You must specify the <code>SourceEnvironmentName</code> with the <code>DestinationEnvironmentName</code>.
        ///      
        /// </para>
        /// </summary>
        public string DestinationEnvironmentName
        {
            get { return this._destinationEnvironmentName; }
            set { this._destinationEnvironmentName = value; }
        }


        /// <summary>
        /// Sets the DestinationEnvironmentName property
        /// </summary>
        /// <param name="destinationEnvironmentName">The value to set for the DestinationEnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SwapEnvironmentCNAMEsRequest WithDestinationEnvironmentName(string destinationEnvironmentName)
        {
            this._destinationEnvironmentName = destinationEnvironmentName;
            return this;
        }

        // Check to see if DestinationEnvironmentName property is set
        internal bool IsSetDestinationEnvironmentName()
        {
            return this._destinationEnvironmentName != null;
        }


        /// <summary>
        /// Gets and sets the property SourceEnvironmentId. 
        /// <para>
        ///          The ID of the source environment.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify at least the <code>SourceEnvironmentID</code>
        /// or the <code>SourceEnvironmentName</code>.          You may also specify both.   
        ///      If you specify the <code>SourceEnvironmentId</code>, you must specify the <code>DestinationEnvironmentId</code>.
        ///      
        /// </para>
        /// </summary>
        public string SourceEnvironmentId
        {
            get { return this._sourceEnvironmentId; }
            set { this._sourceEnvironmentId = value; }
        }


        /// <summary>
        /// Sets the SourceEnvironmentId property
        /// </summary>
        /// <param name="sourceEnvironmentId">The value to set for the SourceEnvironmentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SwapEnvironmentCNAMEsRequest WithSourceEnvironmentId(string sourceEnvironmentId)
        {
            this._sourceEnvironmentId = sourceEnvironmentId;
            return this;
        }

        // Check to see if SourceEnvironmentId property is set
        internal bool IsSetSourceEnvironmentId()
        {
            return this._sourceEnvironmentId != null;
        }


        /// <summary>
        /// Gets and sets the property SourceEnvironmentName. 
        /// <para>
        ///          The name of the source environment.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify at least the <code>SourceEnvironmentID</code>
        /// or the <code>SourceEnvironmentName</code>.          You may also specify both.   
        ///      If you specify the <code>SourceEnvironmentName</code>, you must specify the <code>DestinationEnvironmentName</code>.
        ///      
        /// </para>
        /// </summary>
        public string SourceEnvironmentName
        {
            get { return this._sourceEnvironmentName; }
            set { this._sourceEnvironmentName = value; }
        }


        /// <summary>
        /// Sets the SourceEnvironmentName property
        /// </summary>
        /// <param name="sourceEnvironmentName">The value to set for the SourceEnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SwapEnvironmentCNAMEsRequest WithSourceEnvironmentName(string sourceEnvironmentName)
        {
            this._sourceEnvironmentName = sourceEnvironmentName;
            return this;
        }

        // Check to see if SourceEnvironmentName property is set
        internal bool IsSetSourceEnvironmentName()
        {
            return this._sourceEnvironmentName != null;
        }

    }
}