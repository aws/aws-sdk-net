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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutoScalingInstances operation.
    /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
    /// list.            If a list is not provided, the service returns the full details of
    /// all instances up to a maximum of 50.             By default, the service returns a
    /// list of 20 items.        
    /// 
    ///         
    /// <para>
    ///             This action supports pagination by returning a token if there are more
    /// pages to retrieve.            To get the next page, call this action again with the
    /// returned token as the <code>NextToken</code> parameter.        
    /// </para>
    /// </summary>
    public partial class DescribeAutoScalingInstancesRequest : AmazonWebServiceRequest
    {
        private List<string> _instanceIds = new List<string>();
        private int? _maxRecords;
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        ///             The list of Auto Scaling instances to describe.             If this list
        /// is omitted, all auto scaling instances are described.             The list of requested
        /// instances cannot contain more than            50 items. If unknown instances are requested,
        ///            they are ignored with no error.        
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }
        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///             The maximum number of Auto Scaling instances to be described         
        ///   with each call.        
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///             The token returned by a previous call             to indicate that there
        /// is more data available.        
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }


        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesRequest WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}