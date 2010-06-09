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
    /// Returns the default engine and system parameter information for each supported database engine. You can
    /// call this operation recursively using the Marker parameter.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DescribeEngineDefaultParametersRequest
    {
        private string engineField;
        private Decimal? maxRecordsField;
        private string markerField;

        /// <summary>
        /// Gets and sets the Engine property.
        /// Name of the database engine. Valid Values: MySQL5.1.
        /// </summary>
        [XmlElementAttribute(ElementName = "Engine")]
        public string Engine
        {
            get { return this.engineField; }
            set { this.engineField = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">Name of the database engine. Valid Values: MySQL5.1.</param>
        /// <returns>this instance</returns>
        public DescribeEngineDefaultParametersRequest WithEngine(string engine)
        {
            this.engineField = engine;
            return this;
        }

        /// <summary>
        /// Checks if Engine property is set
        /// </summary>
        /// <returns>true if Engine property is set</returns>
        public bool IsSetEngine()
        {
            return this.engineField != null;
        }

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxRecords")]
        public Decimal MaxRecords
        {
            get { return this.maxRecordsField.GetValueOrDefault(); }
            set { this.maxRecordsField = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">MaxRecords property</param>
        /// <returns>this instance</returns>
        public DescribeEngineDefaultParametersRequest WithMaxRecords(Decimal maxRecords)
        {
            this.maxRecordsField = maxRecords;
            return this;
        }

        /// <summary>
        /// Checks if MaxRecords property is set
        /// </summary>
        /// <returns>true if MaxRecords property is set</returns>
        public bool IsSetMaxRecords()
        {
            return this.maxRecordsField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Marker property.
        /// The marker provided in the previous request. If this parameter is specified, the response includes only records beyond the marker, up to MaxRecords.
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
        /// <param name="marker">The marker provided in the previous request. If this parameter is specified, the response includes only records beyond the marker, up to MaxRecords.</param>
        /// <returns>this instance</returns>
        public DescribeEngineDefaultParametersRequest WithMarker(string marker)
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

    }
}
