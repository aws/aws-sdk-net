/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the ListActivityTypes operation.
    /// <para> Returns information about all activities registered in the specified domain that match the specified name and registration status.
    /// The result includes information like creation date, current status of the activity, etc. The results may be split into multiple pages. To
    /// retrieve subsequent pages, make the call again using the <c>nextPageToken</c> returned by the initial call. </para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.ListActivityTypes"/>
    public class ListActivityTypesRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string name;
        private string registrationStatus;
        private string nextPageToken;
        private int? maximumPageSize;
        private bool? reverseOrder;

        /// <summary>
        /// The name of the domain in which the activity types have been registered.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;       
        }

        /// <summary>
        /// If specified, only lists the activity types that have this name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }

        /// <summary>
        /// Specifies the registration status of the activity types to list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>REGISTERED, DEPRECATED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RegistrationStatus
        {
            get { return this.registrationStatus; }
            set { this.registrationStatus = value; }
        }

        /// <summary>
        /// Sets the RegistrationStatus property
        /// </summary>
        /// <param name="registrationStatus">The value to set for the RegistrationStatus property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithRegistrationStatus(string registrationStatus)
        {
            this.registrationStatus = registrationStatus;
            return this;
        }
            

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this.registrationStatus != null;       
        }

        /// <summary>
        /// If on a previous call to this method a <c>NextResultToken</c> was returned, the results have more than one page. To get the next page of
        /// results, repeat the call with the <c>nextPageToken</c> and keep all other arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;       
        }

        /// <summary>
        /// The maximum number of results returned in each page. The default is 100, but the caller can override this value to a page size
        /// <i>smaller</i> than the default. You cannot specify a page size greater than 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this.maximumPageSize ?? default(int); }
            set { this.maximumPageSize = value; }
        }

        /// <summary>
        /// Sets the MaximumPageSize property
        /// </summary>
        /// <param name="maximumPageSize">The value to set for the MaximumPageSize property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithMaximumPageSize(int maximumPageSize)
        {
            this.maximumPageSize = maximumPageSize;
            return this;
        }
            

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this.maximumPageSize.HasValue;       
        }

        /// <summary>
        /// When set to <c>true</c>, returns the results in reverse order. By default the results are returned in ascending alphabetical order of the
        /// <c>name</c> of the activity types.
        ///  
        /// </summary>
        public bool ReverseOrder
        {
            get { return this.reverseOrder ?? default(bool); }
            set { this.reverseOrder = value; }
        }

        /// <summary>
        /// Sets the ReverseOrder property
        /// </summary>
        /// <param name="reverseOrder">The value to set for the ReverseOrder property </param>
        /// <returns>this instance</returns>
        public ListActivityTypesRequest WithReverseOrder(bool reverseOrder)
        {
            this.reverseOrder = reverseOrder;
            return this;
        }
            

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this.reverseOrder.HasValue;       
        }
    }
}
    
