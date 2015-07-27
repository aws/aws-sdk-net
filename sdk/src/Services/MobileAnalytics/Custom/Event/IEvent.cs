/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Collections;
using System.Collections.Generic;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using System;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager
{
    
    /// <summary>
    /// Interface for Mobile Analytics Event.
    /// </summary>
    public interface IEvent
    {
        #region attribute
        /// <summary>
        /// Adds the attribute.
        /// </summary>
        /// <param name="attributeName">Attribute name. Max name length is 50.</param>
        /// <param name="attributeValue">Attribute value. Max value length is 255.</param>
        void AddAttribute(string attributeName, string attributeValue);
        
        /// <summary>
        /// Determines whether this instance has attribute the specified attributeName.
        /// </summary>
        /// <returns><c>true</c> if this instance has attribute the specified attributeName; otherwise, <c>false</c>.</returns>
        /// <param name="attributeName">Attribute name.</param>
        bool HasAttribute(string attributeName);
        
        /// <summary>
        /// Gets the attribute.
        /// </summary>
        /// <returns>The attribute. Return null if the attribute doesn't exist.</returns>
        /// <param name="attributeName">Attribute name.</param>
        string GetAttribute(string attributeName);
        
        /// <summary>
        /// Gets all attributes.
        /// </summary>
        /// <returns>All the attributes.</returns>
        IDictionary<string, string> AllAttributes { get;  }
        #endregion
        
        #region metric
        /// <summary>
        /// Adds the metric.
        /// </summary>
        /// <param name="metricName">Metric name. Max length is 50.</param>
        /// <param name="metricValue">Metric value.</param>
        void AddMetric(string metricName, double metricValue);
        
        /// <summary>
        /// Determines whether this instance has metric the specified metricName.
        /// </summary>
        /// <returns><c>true</c> if this instance has metric the specified metricName; otherwise, <c>false</c>.</returns>
        /// <param name="metricName">Metric name.</param>
        bool HasMetric(string metricName);
        
        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <returns>The metric. Return null if metric doesn't exist.</returns>
        /// <param name="metricName">Metric name.</param>
        double? GetMetric(string metricName);
        
        /// <summary>
        /// Gets all metrics.
        /// </summary>
        /// <returns>All the metrics.</returns>
        IDictionary<string, double> AllMetrics { get; }   
        #endregion
        
        #region gloablattribute
        /// <summary>
        /// Adds the global attribute, which is valid for all events.
        /// </summary>
        /// <param name="attributeName">Attribute name. Max length is 50.</param>
        /// <param name="attributeValue">Attribute value. Max length is 255.</param>
        void AddGlobalAttribute(string attributeName, string attributeValue);
        
        /// <summary>
        /// Adds the global attribute, which is valid to some specific event type.
        /// </summary>
        /// <param name="eventType">Event type.</param>
        /// <param name="attributeName">Attribute name. Max length is 50.</param>
        /// <param name="attributeValue">Attribute value. Max length is 255.</param>
        void AddGlobalAttribute(string eventType, string attributeName, string attributeValue);
        
        /// <summary>
        /// Removes the global attribute, which is valid for all events.
        /// </summary>
        /// <param name="attributeName">Attribute name.</param>
        void RemoveGlobalAttribute(string attributeName);
        
        /// <summary>
        /// Removes the global attribute, which is valid to some specific event type.
        /// </summary>
        /// <param name="eventType">Event type.</param>
        /// <param name="attributeName">Attribute name.</param>
        void RemoveGlobalAttribute(string eventType, string attributeName);
        
        /// <summary>
        /// Gets the global attribute, which is valid for all events.
        /// </summary>
        /// <returns>The global attribute. Return null if attribute doesn't exist.</returns>
        /// <param name="attributeName">Attribute name.</param>
        string GetGlobalAttribute(string attributeName);
        
        /// <summary>
        /// Gets the global attribute, which is valid for some specific event type.
        /// </summary>
        /// <returns>The global attribute. Return null if attribute doesn't exist. </returns>
        /// <param name="eventType">Event type.</param>
        /// <param name="attributeName">Attribute name.</param>
        string GetGlobalAttribute(string eventType, string attributeName);
        #endregion
        
        #region globalmetric
        /// <summary>
        /// Adds the global metric, which is valid for all events.
        /// </summary>
        /// <param name="metricName">Metric name. Max length is 50.</param>
        /// <param name="metricValue">Metric value.</param>
        void AddGlobalMetric(string metricName, double metricValue);
        
        /// <summary>
        /// Adds the global metric, which is valid for some specific event type.
        /// </summary>
        /// <param name="eventType">Event type.</param>
        /// <param name="metricName">Metric name. Max length is 50.</param>
        /// <param name="metricValue">Metric value.</param>
        void AddGlobalMetric(string eventType, string metricName, double metricValue);
        
        /// <summary>
        /// Removes the global metric, which is valid for all events.
        /// </summary>
        /// <param name="metricName">Metric name.</param>
        void RemoveGlobalMetric(string metricName);
        
        /// <summary>
        /// Removes the global metric, which is valid for some specific event type.
        /// </summary>
        /// <param name="eventType">Event type.</param>
        /// <param name="metricName">Metric name.</param>
        void RemoveGlobalMetric(string eventType,string metricName);
        
        /// <summary>
        /// Gets the global metric, which is valid for all events.
        /// </summary>
        /// <returns>The global metric.Return null if metric doesn't exist.</returns>
        /// <param name="metricName">Metric name.</param>
        double? GetGlobalMetric(string metricName);
        
        /// <summary>
        /// Gets the global metric, which is valid for some specific event type.
        /// </summary>
        /// <returns>The global metric.Return null if metric doesn't exist.</returns>
        /// <param name="eventType">Event type.</param>
        /// <param name="metricName">Metric name.</param>
        double? GetGlobalMetric(string eventType, string metricName);
        #endregion



    
    }
    
}


