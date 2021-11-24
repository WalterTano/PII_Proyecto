﻿# Proyecto final de Programación II, Equipo 13
<h2>Diagrama de clases</h2>
<img src="./docs/ProyectoFinal_E13_UML(2).jpg" alt="Diagrama de clases">
<h2>CRC</h2>
<h3><a href="./docs/CRC Chatbot.pdf"> • CRCs en el repositorio</a></h3>
<h3><a href="https://echeung.me/crcmaker/?share=W3sibmFtZSI6IlNpc3RlbWEgLSBXYWx0ZXIgVGHxbyIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgdG9kYXMgbGFzIEVNUFJFU0FTLiIsIkNvbm9jZXIgdG9kb3MgbG9zIEVNUFJFTkRFRE9SRVMuIiwiUmVnaXN0cmFyIEVNUFJFU0FTLiIsIlJlZ2lzdHJhciBFTVBSRU5ERURPUkVTLiJdLCJjb2xsYWJvcmF0b3JzIjpbIkVtcHJlc2EiLCJFbXByZW5kZWRvciJdfSx7Im5hbWUiOiJCdXNjYWRvciAtIFdhbHRlciBUYfFvIiwic3VwZXJjbGFzc2VzIjoiIiwic3ViY2xhc3NlcyI6IiIsInR5cGUiOjEsInJlc3BvbnNpYmlsaXRpZXMiOlsiQ29ub2NlciBhbCBTSVNURU1BIiwiRGFkbyB1biBFTVBSRU5ERURPUiB5IHVuYSBsaXN0YSBkZSBwYWxhYnJhcyBjbGF2ZSwgcHJvdmVlciB1bmEgbGlzdGEgZGUgT0ZFUlRBUy4iXSwiY29sbGFib3JhdG9ycyI6WyJTaXN0ZW1hIiwiRW1wcmVuZGVkb3IiLCJPZmVydGEiXX0seyJuYW1lIjoiRW1wcmVzYSAtIEV6ZXF1aWVsIEdvbWV6Iiwic3VwZXJjbGFzc2VzIjoiIiwic3ViY2xhc3NlcyI6IiIsInR5cGUiOjEsInJlc3BvbnNpYmlsaXRpZXMiOlsiQ29ub2NlciBzdSBpZCBlbiBlbCBzaXN0ZW1hIiwiQ29ub2NlciBzdSBub21icmUiLCJDb25vY2VyIHN1IFVCSUNBQ0lPTiIsIkNvbm9jZXIgc3UgcnVicm8iLCJDb25vY2VyIHkgdmVyIHN1cyBwcm9waWFzIE9GRVJUQVMgKGFjdGl2YXMgeSBmaW5hbGl6YWRhcykiLCJDcmVhciBzdXMgT0ZFUlRBUyIsIkFjdHVhbGl6YXIgZXN0YWRvIGRlIE9GRVJUQVMiXSwiY29sbGFib3JhdG9ycyI6WyJPZmVydGEiLCJVYmljYWNpb24iLCJUZWxlZ3JhbSIsIlJ1YnJvIl19LHsibmFtZSI6IkVtcHJlbmRlZG9yIC0gTHVjYXMgR2lmZnVuaSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgc3Ugbm9tYnJlIiwiQ29ub2NlciBzdXMgaGFiaWxpdGFjaW9uZXMiLCJDb25vY2VyIHN1IFVCSUNBQ0lPTiIsIkNvbm9jZXIgc3UgcnVicm8iLCJDb25vY2VyIHN1cyBPRkVSVEFTIChwb3N0dWxhZGFzIHkgY29uc3VtaWRhcykiLCJCdXNjYXIgeSB2ZXIgT0ZFUlRBUyIsIlBvc3R1bGFyc2UgYSBPRkVSVEFTIl0sImNvbGxhYm9yYXRvcnMiOlsiT2ZlcnRhIiwiVWJpY2FjaW9uIiwiVGVsZWdyYW0iLCJCdXNjYWRvciIsIlJ1YnJvIiwiSGFiaWxpdGFjaW9uIl19LHsibmFtZSI6Ik9mZXJ0YSAtIE1hbnVlbCBJZ2xlc2lhcyIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgc3UgdO10dWxvLiIsIkNvbm9jZXIgc3UgZGVzY3JpcGNp824uIiwiQ29ub2NlciBzdXMgUFJPRFVDVE9TLiIsIkNvbm9jZXIgbGEgRU1QUkVTQSBxdWUgbGEgZ2VuZXJhLiIsIkNvbm9jZXIgc3UgdmFsb3IgdG90YWwgbW9uZXRhcmlvIChlbiAkIHkgVSRTKS4iLCJDb25vY2VyIHN1cyBoYWJpbGl0YWNpb25lcyByZXF1ZXJpZGFzLiIsIkNvbm9jZXIgc3UgZXN0YWRvLiIsIkNvbm9jZXIgc3VzIHBhbGFicmFzIGNsYXZlLiIsIkNvbm9jZXIgc3UgZmVjaGEgZGUgY3JlYWNp824uIiwiQ29ub2NlciBzdSBmZWNoYSBkZSBjaWVycmUuIiwiQ29ub2NlciBsb3MgRU1QUkVOREVET1JFUyBwb3N0dWxhZG9zIGEgbGEgb2ZlcnRhLiIsIlJlZGFjdGFyIHN1IHB1YmxpY2FjafNuICh2ZXJzafNuIGVzY3JpdGEgZGUgbGEgb2ZlcnRhKS4iLCJSZWRhY3RhciBzdSBwdWJsaWNhY2nzbiByZXN1bWlkYS4iLCJSZWRhY3RhciBsYSBsaXN0YSBkZSBFTVBSRU5ERURPUkVTIHBvc3R1bGFkb3MuIl0sImNvbGxhYm9yYXRvcnMiOlsiUHJvZHVjdG8iLCJFbXByZXNhIiwiRW1wcmVuZGVkb3IiLCJUZWxlZ3JhbSIsIkhhYmlsaXRhY2lvbiJdfSx7Im5hbWUiOiJQcm9kdWN0byAtIEZhdXN0aW5vIEhhcnJpYWd1ZSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgdW4gTUFURVJJQUwuIiwiQ29ub2NlciBzdSBVQklDQUNJ004uIiwiQ29ub2NlciBsYSBjYW50aWRhZCAoZW4gc3UgdW5pZGFkKSBkZWwgTUFURVJJQUwgZGlzcG9uaWJsZS4iLCJDb25vY2VyIHN1IHZhbG9yIG1vbmV0YXJpbyB0b3RhbCBlbiAkLiIsIkNvbm9jZXIgc3UgdmFsb3IgbW9uZXRhcmlvIHRvdGFsIGVuIFUkUy4iXSwiY29sbGFib3JhdG9ycyI6WyJVYmljYWNpb24iLCJNYXRlcmlhbCJdfSx7Im5hbWUiOiJNYXRlcmlhbCAtIE1hbnVlbCBJZ2xlc2lhcyIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgc3Ugbm9tYnJlLiIsIkNvbm9jZXIgc3VzIGNhdGVnb3LtYXMuIiwiQ29ub2NlciBzdSB1bmlkYWQgZGUgbWVkaWRhIGVzdOFuZGFyLiJdLCJjb2xsYWJvcmF0b3JzIjpbIiJdfSx7Im5hbWUiOiJVYmljYWNpb24gLSBFemVxdWllbCBHb21leiIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgY2FsbGUiLCJDb25vY2VyIGVzcXVpbmEiLCJDb25vY2VyIG51bWVybyBkZSBwdWVydGEiLCJDb25vY2VyIGNpdWRhZCIsIkNvbm9jZXIgZGVwYXJ0YW1lbnRvIiwiUmVkYWN0YXIgbGEgdWJpY2FjafNuIHJlcHJlc2VudGFkYSJdLCJjb2xsYWJvcmF0b3JzIjpbIiJdfSx7Im5hbWUiOiJJUGVyc2lzdGVuY2lhIC0gRmF1c3Rpbm8gSGFycmlhZ3VlIiwic3VwZXJjbGFzc2VzIjoiIiwic3ViY2xhc3NlcyI6IiIsInR5cGUiOjEsInJlc3BvbnNpYmlsaXRpZXMiOlsiQWxtYWNlbmFyIGluZm9ybWFjafNuIGVuIG1lZGlvcyBwZXJzaXN0ZW50ZXMiLCJMZWVyIGluZm9ybWFjafNuIGRlIG1lZGlvcyBwZXJzaXN0ZW50ZXMiXSwiY29sbGFib3JhdG9ycyI6WyIiXX0seyJuYW1lIjoiSUNhbmFsIC0gTHVjYXMgR2lmZnVuaSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIlJlY2liaXIgbWVuc2FqZXMgZGUgdW4gY2FuYWwgZGUgY29tdW5pY2FjafNuIiwiRW52aWFyIG1lbnNhamVzIGEgdW4gY2FuYWwgZGUgY29tdW5pY2FjafNuIl0sImNvbGxhYm9yYXRvcnMiOlsiIl19LHsibmFtZSI6IlJ1YnJvIC0gTHVjYXMgR2lmZnVuaSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgZWwgbm9tYnJlIGRlbCBydWJybyBxdWUgcmVwcmVzZW50YS4iXSwiY29sbGFib3JhdG9ycyI6WyIiXX0seyJuYW1lIjoiSGFiaWxpdGFjaW9uIC0gTHVjYXMgR2lmZnVuaSIsInN1cGVyY2xhc3NlcyI6IiIsInN1YmNsYXNzZXMiOiIiLCJ0eXBlIjoxLCJyZXNwb25zaWJpbGl0aWVzIjpbIkNvbm9jZXIgbGEgZGVzY3JpcGNp824gZGUgdW5hIGhhYmlsaXRhY2nzbiIsIkNvbm9jZXIgZWwgbm9tYnJlIGRlIGxhIGluc3RpdHVjafNuIHF1ZSBleHBpZGnzIiwiQ29ub2NlciBmZWNoYSBkZSB0cuFtaXRlIiwiQ29ub2NlciBmZWNoYSBkZSB2ZW5jaW1pZW50byIsIkNvbm9jZXIgZXN0YWRvIGRlIHZpZ2VuY2lhIl0sImNvbGxhYm9yYXRvcnMiOlsiIl19XQ=="> • CRCs en CRC Maker</a></h3>

## Reflexión de la segunda entrega
Encontramos difícil desarrollar la solución sin tener definida la persistencia del proyecto. También fue difícil la ejecución de los merge en GitHub, sobre todo en lo que respecta a estar todo el tiempo coordinados en lo que estamos haciendo. 

Aprendimos sobre las implicaciones de integrar distintos patrones y principios simultáneamente, haciendo hincapié en la creación de abstracciones que dieran las cualidades buscadas a nuestra solución y evaluando cuando un principio o patrón convendría que tomara precedencia sobre otro. 

Utilizamos la web de la IMM para conocer sobre las habilitaciones que existen y sus características. También utilizamos la documentación sobre principios y patrones, "Dive Into Design Patterns" de Alexander Shvets, así como "Applying Uml And Patterns" de Craig Larman. Otra fuente de información que utilizamos fue la documentación de Microsoft .
