/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A list of DB Instance information
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DescribeDBInstancesResult
    {
        private string markerField;
        private List<DBInstance> DBInstanceField;

        /// <summary>
        /// Gets and sets the Marker property.
        /// Identifier returned to allow retrieval of paginated results.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.markerField; }
            set { this.markerField = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">Identifier returned to allow retrieval of paginated results.</param>
        /// <returns>this instance</returns>
        public DescribeDBInstancesResult WithMarker(string marker)
        {
            this.markerField = marker;
            return this;
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        public bool IsSetMarker()
        {
            return this.markerField != null;
        }
        /// <summary>
        /// Gets and sets the DBInstance property.
        /// A list of DB Instance information
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstance")]
        public List<DBInstance> DBInstance
        {
            get
            {
                if (this.DBInstanceField == null)
                {
                    this.DBInstanceField = new List<DBInstance>();
                }
                return this.DBInstanceField;
            }
            set { this.DBInstanceField = value; }
        }

        /// <summary>
        /// Sets the DBInstance property
        /// </summary>
        /// <param name="list">A list of DB Instance information</param>
        /// <returns>this instance</returns>
        public DescribeDBInstancesResult WithDBInstance(params DBInstance[] list)
        {
            foreach (DBInstance item in list)
            {
                DBInstance.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DBInstance property is set
        /// </summary>
        /// <returns>true if DBInstance property is set</returns>
        public bool IsSetDBInstance()
        {
            return (DBInstance.Count > 0);
        }

    }
}
