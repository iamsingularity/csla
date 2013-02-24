﻿//-----------------------------------------------------------------------
// <copyright file="IDataPortalActivator.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Defines a type used to activate concrete business instances.</summary>
//-----------------------------------------------------------------------
using System;

namespace Csla.Server
{
  /// <summary>
  /// Defines a type used to activate concrete business
  /// instances.
  /// </summary>
  public interface IDataPortalActivator
  {
    /// <summary>
    /// Gets a new instance of the requested type.
    /// </summary>
    /// <param name="requestedType">Requested business type (class or interface).</param>
    /// <returns>Business object instance.</returns>
    object CreateInstance(Type requestedType);
    /// <summary>
    /// Initializes an existing business object instance.
    /// </summary>
    /// <param name="obj">Reference to the business object.</param>
    void InitializeInstance(object obj);
  }
}
