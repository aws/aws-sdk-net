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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Filter criteria to use in determining which extensions to return.
    /// </summary>
    public partial class TypeFilters
    {
        private Category _category;
        private string _publisherId;
        private string _typeNamePrefix;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of extensions to return.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGISTERED</c>: Private extensions that have been registered for this account
        /// and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATED</c>: Public extensions that have been activated for this account and
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THIRD_PARTY</c>: Extensions available for use from publishers other than Amazon.
        /// This includes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Private extensions registered in the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Public extensions from publishers other than Amazon, whether activated or not.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>AWS_TYPES</c>: Extensions available for use from Amazon.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Category Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The id of the publisher of the extension.
        /// </para>
        ///  
        /// <para>
        /// Extensions published by Amazon aren't assigned a publisher ID. Use the <c>AWS_TYPES</c>
        /// category to specify a list of types published by Amazon.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

        /// <summary>
        /// Gets and sets the property TypeNamePrefix. 
        /// <para>
        /// A prefix to use as a filter for results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=204)]
        public string TypeNamePrefix
        {
            get { return this._typeNamePrefix; }
            set { this._typeNamePrefix = value; }
        }

        // Check to see if TypeNamePrefix property is set
        internal bool IsSetTypeNamePrefix()
        {
            return this._typeNamePrefix != null;
        }

    }
}