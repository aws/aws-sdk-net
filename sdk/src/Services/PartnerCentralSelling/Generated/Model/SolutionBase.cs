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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Specifies minimal information for the solution offered to solve the customer's business
    /// problem.
    /// </summary>
    public partial class SolutionBase
    {
        private string _arn;
        private string _catalog;
        private string _category;
        private DateTime? _createdDate;
        private string _id;
        private string _name;
        private SolutionStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The SolutionBase structure provides essential information about a solution. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the solution is hosted, either <c>AWS</c> or <c>Sandbox</c>.
        /// This helps partners differentiate between live solutions and those in testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Specifies the solution category, which helps to categorize and organize the solutions
        /// partners offer. Valid values: <c>Software Product</c> | <c>Consulting Service</c>
        /// | <c>Hardware Product</c> | <c>Communications Product</c> | <c>Professional Service</c>
        /// | <c>Managed Service</c> | <c>Value-Added Resale Amazon Web Services Service</c> |
        /// <c>Distribution Service</c> | <c>Training Service</c> | <c>Merger and Acquisition
        /// Advising Service</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Category
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Indicates the solution creation date. This is useful to track and audit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Enables the association of solutions (offerings) to opportunities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the solution name.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the solution's current status, which indicates its state in the system.
        /// Valid values: <c>Active</c> | <c>Inactive</c> | <c>Draft</c>. The status helps partners
        /// and Amazon Web Services track the solution's lifecycle and availability. Filter for
        /// <c>Active</c> solutions for association to an opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SolutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}